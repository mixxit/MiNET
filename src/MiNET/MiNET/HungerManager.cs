using System;
using log4net;
using MiNET.Items;
using MiNET.Net;

namespace MiNET
{
	public class HungerManager
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof (HungerManager));

		public Player Player { get; set; }

		public int Hunger { get; set; } = 20;
		public int MinHunger { get; set; } = 0;
		public int MaxHunger { get; set; } = 20;
		public double Saturation { get; set; }
		public double Exhaustion { get; set; }

		public HungerManager(Player player)
		{
			Player = player;
			ResetHunger();
		}

		public virtual void IncreaseFoodAndSaturation(Item item, int foodPoints, double saturationRestore)
		{
			Hunger += foodPoints;
			Saturation += saturationRestore;

			ProcessHunger(true);
		}

		public virtual void IncreaseExhaustion(float amount)
		{
			Exhaustion += amount;
			ProcessHunger();
		}

		public virtual void Move(double distance)
		{
			if (distance < 0) throw new Exception("Distance: " + distance);
			// 0.01 per meter for walking
			// 0.005 for sneaking
			// 0.1 for sprinting

			double movementStrainFactor = 0.01; // Default for walking

			if (Player.IsSneaking)
			{
				movementStrainFactor = 0.005;
			}
			else if (Player.IsSprinting)
			{
				movementStrainFactor = 0.1;
			}

			Exhaustion += (distance*movementStrainFactor);

			ProcessHunger();
		}

		public virtual void ProcessHunger(bool forceSend = false)
		{
			bool send = forceSend;

			if (Hunger > MaxHunger)
			{
				Hunger = MaxHunger;
				send = true;
			}

			if (Saturation > Hunger)
			{
				Saturation = Hunger;
				send = true;
			}

			while (Exhaustion >= 4)
			{
				Exhaustion -= 4;

				if (Saturation > 0)
				{
					Saturation -= 1;
					if (Saturation < 0) send = true;
				}
				else
				{
					Hunger -= 1;
					Saturation = 0;

					if (Hunger < 0) Hunger = 0; // Damage!
					send = true;
				}
			}

			if (send) SendHungerAttributes();
		}

		private long _ticker;

		public virtual void OnTick()
		{
			if (Hunger <= 0)
			{
				_ticker++;

				if (_ticker%80 == 0)
				{
					Player.HealthManager.TakeHit(null, 1, DamageCause.Unknown);
				}
			}
			else if (Hunger > 18 && Player.HealthManager.Hearts < 20)
			{
				_ticker++;

				if (Hunger >= 20 && Saturation > 0)
				{
					if (_ticker%10 == 0)
					{
						IncreaseExhaustion(4);
						Player.HealthManager.Regen(1);
					}
				}
				else
				{
					if (_ticker%80 == 0)
					{
						IncreaseExhaustion(4);
						Player.HealthManager.Regen(1);
					}
				}
			}
			else
			{
				_ticker = 0;
			}

			//DisplayDebugPopup();
		}

		public void DisplayDebugPopup()
		{
			if (Log.IsDebugEnabled)
			{
				if (Player.Level.TickTime%10 == 0)
				{
					if (Player.Username.Equals("gurunx"))
					{
						Popup popup = new Popup
						{
							Duration = 1,
							MessageType = MessageType.Tip,
							Message = $"Saturation={Saturation}, Exhaustion={Exhaustion:F3}"
						};

						Player.AddPopup(popup);
					}
				}
			}
		}

		public virtual PlayerAttributes AddHungerAttributes(PlayerAttributes attributes)
		{
			attributes["minecraft:player.hunger"] = new PlayerAttribute
			{
				Name = "minecraft:player.hunger",
				MinValue = MinHunger,
				MaxValue = MaxHunger,
				Value = Hunger,
				Unknown = Hunger,
			};

			attributes["minecraft:player.saturation"] = new PlayerAttribute
			{
				Name = "minecraft:player.saturation",
				MinValue = 0,
				MaxValue = Hunger,
				Value = (float) Saturation,
				Unknown = (float) Saturation,
			};
			attributes["minecraft:player.exhaustion"] = new PlayerAttribute
			{
				Name = "minecraft:player.exhaustion",
				MinValue = 0,
				MaxValue = 5,
				Value = (float) Exhaustion,
				Unknown = (float) Exhaustion,
			};

			return attributes;
		}


		public virtual void SendHungerAttributes()
		{
			var attributes = AddHungerAttributes(new PlayerAttributes());

			McpeUpdateAttributes attributesPackate = McpeUpdateAttributes.CreateObject();
			attributesPackate.entityId = 0;
			attributesPackate.attributes = attributes;
			Player.SendPackage(attributesPackate);
		}

		public virtual void ResetHunger()
		{
			Hunger = MaxHunger;
			Saturation = Hunger;
			Exhaustion = 0;
		}
	}
}