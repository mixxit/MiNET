using System.Collections.Generic;
using fNbt;
using MiNET.Items;
using MiNET.Utils;

namespace MiNET
{
	// ReSharper disable RedundantArgumentDefaultValue
	public static class InventoryUtils
	{
		public static ItemStacks GetCreativeMetadataSlots()
		{
			ItemStacks slotData = new ItemStacks();
			for (int i = 0; i < CreativeInventoryItems.Count; i++)
			{
				slotData.Add(CreativeInventoryItems[i]);
			}

			return slotData;
		}

		// GENERATED CODE. DON'T EDIT BY HAND
		public static List<Item> CreativeInventoryItems = new List<Item>()
		{
			new Item(138, 0, 1),
			new Item(66, 0, 1),
			new Item(27, 0, 1),
			new Item(28, 0, 1),
			new Item(126, 0, 1),
			new Item(4, 0, 1),
			new Item(98, 0, 1),
			new Item(98, 1, 1),
			new Item(98, 2, 1),
			new Item(98, 3, 1),
			new Item(48, 0, 1),
			new Item(5, 0, 1),
			new Item(5, 1, 1),
			new Item(5, 2, 1),
			new Item(5, 3, 1),
			new Item(5, 4, 1),
			new Item(5, 5, 1),
			new Item(45, 0, 1),
			new Item(1, 0, 1),
			new Item(1, 1, 1),
			new Item(1, 2, 1),
			new Item(1, 3, 1),
			new Item(1, 4, 1),
			new Item(1, 5, 1),
			new Item(1, 6, 1),
			new Item(3, 0, 1),
			new Item(243, 0, 1),
			new Item(2, 0, 1),
			new Item(110, 0, 1),
			new Item(82, 0, 1),
			new Item(172, 0, 1),
			new Item(159, 0, 1),
			new Item(159, 1, 1),
			new Item(159, 2, 1),
			new Item(159, 3, 1),
			new Item(159, 4, 1),
			new Item(159, 5, 1),
			new Item(159, 6, 1),
			new Item(159, 7, 1),
			new Item(159, 8, 1),
			new Item(159, 9, 1),
			new Item(159, 10, 1),
			new Item(159, 11, 1),
			new Item(159, 12, 1),
			new Item(159, 13, 1),
			new Item(159, 14, 1),
			new Item(159, 15, 1),
			new Item(24, 0, 1),
			new Item(24, 1, 1),
			new Item(24, 2, 1),
			new Item(179, 0, 1),
			new Item(179, 1, 1),
			new Item(179, 2, 1),
			new Item(12, 0, 1),
			new Item(12, 1, 1),
			new Item(13, 0, 1),
			new Item(139, 0, 1),
			new Item(139, 1, 1),
			new Item(17, 0, 1),
			new Item(17, 1, 1),
			new Item(17, 2, 1),
			new Item(17, 3, 1),
			new Item(162, 0, 1),
			new Item(162, 1, 1),
			new Item(112, 0, 1),
			new Item(87, 0, 1),
			new Item(88, 0, 1),
			new Item(7, 0, 1),
			new Item(67, 0, 1),
			new Item(53, 0, 1),
			new Item(134, 0, 1),
			new Item(135, 0, 1),
			new Item(136, 0, 1),
			new Item(163, 0, 1),
			new Item(164, 0, 1),
			new Item(108, 0, 1),
			new Item(128, 0, 1),
			new Item(180, 0, 1),
			new Item(109, 0, 1),
			new Item(114, 0, 1),
			new Item(156, 0, 1),
			new Item(44, 0, 1),
			new Item(44, 3, 1),
			new Item(111, 0, 1),
			new Item(158, 0, 1),
			new Item(158, 1, 1),
			new Item(158, 2, 1),
			new Item(158, 3, 1),
			new Item(158, 4, 1),
			new Item(158, 5, 1),
			new Item(44, 4, 1),
			new Item(44, 1, 1),
			new Item(182, 0, 1),
			new Item(44, 5, 1),
			new Item(44, 6, 1),
			new Item(44, 7, 1),
			new Item(155, 0, 1),
			new Item(155, 2, 1),
			new Item(155, 1, 1),
			new Item(168, 0, 1),
			new Item(168, 2, 1),
			new Item(168, 1, 1),
			new Item(169, 0, 1),
			new Item(263, 0, 1),
			new Item(263, 1, 1),
			new Item(264, 0, 1),
			new Item(265, 0, 1),
			new Item(266, 0, 1),
			new Item(388, 0, 1),
			new Item(280, 0, 1),
			new Item(281, 0, 1),
			new Item(287, 0, 1),
			new Item(288, 0, 1),
			new Item(318, 0, 1),
			new Item(334, 0, 1),
			new Item(415, 0, 1),
			new Item(337, 0, 1),
			new Item(353, 0, 1),
			new Item(336, 0, 1),
			new Item(405, 0, 1),
			new Item(16, 0, 1),
			new Item(15, 0, 1),
			new Item(14, 0, 1),
			new Item(56, 0, 1),
			new Item(21, 0, 1),
			new Item(73, 0, 1),
			new Item(129, 0, 1),
			new Item(153, 0, 1),
			new Item(41, 0, 1),
			new Item(42, 0, 1),
			new Item(57, 0, 1),
			new Item(22, 0, 1),
			new Item(173, 0, 1),
			new Item(133, 0, 1),
			new Item(152, 0, 1),
			new Item(406, 0, 1),
			new Item(49, 0, 1),
			new Item(79, 0, 1),
			new Item(174, 0, 1),
			new Item(80, 0, 1),
			new Item(78, 0, 1),
			new Item(20, 0, 1),
			new Item(89, 0, 1),
			new Item(106, 0, 1),
			new Item(65, 0, 1),
			new Item(19, 0, 1),
			new Item(19, 1, 1),
			new Item(50, 0, 1),
			new Item(102, 0, 1),
			new Item(325, 0, 1),
			new Item(325, 1, 1),
			new Item(325, 8, 1),
			new Item(325, 10, 1),
			new Item(339, 0, 1),
			new Item(340, 0, 1),
			new Item(262, 0, 1),
			new Item(352, 0, 1),
			new Item(324, 0, 1),
			new Item(427, 0, 1),
			new Item(428, 0, 1),
			new Item(429, 0, 1),
			new Item(430, 0, 1),
			new Item(431, 0, 1),
			new Item(330, 0, 1),
			new Item(395, 0, 1),
			new Item(96, 0, 1),
			new Item(167, 0, 1),
			new Item(85, 0, 1),
			new Item(85, 1, 1),
			new Item(85, 2, 1),
			new Item(85, 3, 1),
			new Item(85, 4, 1),
			new Item(85, 5, 1),
			new Item(113, 0, 1),
			new Item(107, 0, 1),
			new Item(183, 0, 1),
			new Item(184, 0, 1),
			new Item(185, 0, 1),
			new Item(187, 0, 1),
			new Item(186, 0, 1),
			new Item(101, 0, 1),
			new Item(355, 0, 1),
			new Item(47, 0, 1),
			new Item(323, 0, 1),
			new Item(321, 0, 1),
			new Item(389, 0, 1),
			new Item(58, 0, 1),
			new Item(245, 0, 1),
			new Item(54, 0, 1),
			new Item(146, 0, 1),
			new Item(61, 0, 1),
			new Item(379, 0, 1),
			new Item(380, 0, 1),
			new Item(25, 0, 1),
			new Item(46, 0, 1),
			new Item(121, 0, 1),
			new Item(120, 0, 1),
			new Item(145, 0, 1),
			new Item(145, 4, 1),
			new Item(145, 8, 1),
			new Item(37, 0, 1),
			new Item(38, 0, 1),
			new Item(38, 1, 1),
			new Item(38, 2, 1),
			new Item(38, 3, 1),
			new Item(38, 4, 1),
			new Item(38, 5, 1),
			new Item(38, 6, 1),
			new Item(38, 7, 1),
			new Item(38, 8, 1),
			new Item(175, 0, 1),
			new Item(175, 1, 1),
			new Item(175, 2, 1),
			new Item(175, 3, 1),
			new Item(175, 4, 1),
			new Item(175, 5, 1),
			new Item(39, 0, 1),
			new Item(40, 0, 1),
			new Item(99, 14, 1),
			new Item(100, 14, 1),
			new Item(99, 0, 1),
			new Item(99, 15, 1),
			new Item(81, 0, 1),
			new Item(103, 0, 1),
			new Item(86, 0, 1),
			new Item(91, 0, 1),
			new Item(30, 0, 1),
			new Item(170, 0, 1),
			new Item(338, 0, 1),
			new Item(296, 0, 1),
			new Item(31, 1, 1),
			new Item(31, 2, 1),
			new Item(32, 0, 1),
			new Item(6, 0, 1),
			new Item(6, 1, 1),
			new Item(6, 2, 1),
			new Item(6, 3, 1),
			new Item(6, 4, 1),
			new Item(6, 5, 1),
			new Item(18, 0, 1),
			new Item(18, 1, 1),
			new Item(18, 2, 1),
			new Item(18, 3, 1),
			new Item(161, 0, 1),
			new Item(161, 1, 1),
			new Item(262, 6, 1),
			new Item(262, 7, 1),
			new Item(262, 8, 1),
			new Item(262, 9, 1),
			new Item(262, 10, 1),
			new Item(262, 11, 1),
			new Item(262, 12, 1),
			new Item(262, 13, 1),
			new Item(262, 14, 1),
			new Item(262, 15, 1),
			new Item(262, 16, 1),
			new Item(262, 17, 1),
			new Item(262, 18, 1),
			new Item(262, 19, 1),
			new Item(262, 20, 1),
			new Item(262, 21, 1),
			new Item(262, 22, 1),
			new Item(262, 23, 1),
			new Item(262, 24, 1),
			new Item(262, 25, 1),
			new Item(262, 26, 1),
			new Item(262, 27, 1),
			new Item(262, 28, 1),
			new Item(262, 29, 1),
			new Item(262, 30, 1),
			new Item(262, 31, 1),
			new Item(262, 32, 1),
			new Item(262, 33, 1),
			new Item(262, 34, 1),
			new Item(262, 35, 1),
			new Item(262, 36, 1),
			new Item(262, 37, 1),
			new Item(295, 0, 1),
			new Item(361, 0, 1),
			new Item(362, 0, 1),
			new Item(458, 0, 1),
			new Item(344, 0, 1),
			new Item(260, 0, 1),
			new Item(322, 0, 1),
			new Item(466, 0, 1),
			new Item(349, 0, 1),
			new Item(460, 0, 1),
			new Item(461, 0, 1),
			new Item(462, 0, 1),
			new Item(350, 0, 1),
			new Item(463, 0, 1),
			new Item(367, 0, 1),
			new Item(282, 0, 1),
			new Item(297, 0, 1),
			new Item(319, 0, 1),
			new Item(320, 0, 1),
			new Item(365, 0, 1),
			new Item(366, 0, 1),
			new Item(423, 0, 1),
			new Item(424, 0, 1),
			new Item(363, 0, 1),
			new Item(364, 0, 1),
			new Item(360, 0, 1),
			new Item(391, 0, 1),
			new Item(392, 0, 1),
			new Item(393, 0, 1),
			new Item(394, 0, 1),
			new Item(457, 0, 1),
			new Item(354, 0, 1),
			new Item(357, 0, 1),
			new Item(400, 0, 1),
			new Item(411, 0, 1),
			new Item(412, 0, 1),
			new Item(413, 0, 1),
			new Item(399, 0, 1),
			new Item(420, 0, 1),
			new Item(421, 0, 1),
			new Item(378, 0, 1),
			new Item(369, 0, 1),
			new Item(371, 0, 1),
			new Item(396, 0, 1),
			new Item(382, 0, 1),
			new Item(414, 0, 1),
			new Item(370, 0, 1),
			new Item(341, 0, 1),
			new Item(377, 0, 1),
			new Item(372, 0, 1),
			new Item(289, 0, 1),
			new Item(331, 0, 1),
			new Item(348, 0, 1),
			new Item(375, 0, 1),
			new Item(376, 0, 1),
			new Item(397, 0, 1),
			new Item(397, 1, 1),
			new Item(397, 2, 1),
			new Item(397, 3, 1),
			new Item(397, 4, 1),
			new Item(261, 0, 1),
			new Item(346, 0, 1),
			new Item(259, 0, 1),
			new Item(359, 0, 1),
			new Item(347, 0, 1),
			new Item(345, 0, 1),
			new Item(398, 0, 1),
			new Item(328, 0, 1),
			new Item(342, 0, 1),
			new Item(408, 0, 1),
			new Item(407, 0, 1),
			new Item(333, 0, 1),
			new Item(333, 1, 1),
			new Item(333, 2, 1),
			new Item(333, 3, 1),
			new Item(333, 4, 1),
			new Item(333, 5, 1),
			new Item(329, 0, 1),
			new Item(416, 0, 1),
			new Item(417, 0, 1),
			new Item(418, 0, 1),
			new Item(419, 0, 1),
			new Item(390, 0, 1),
			new Item(383, 15, 1),
			new Item(383, 10, 1),
			new Item(383, 11, 1),
			new Item(383, 12, 1),
			new Item(383, 13, 1),
			new Item(383, 14, 1),
			new Item(383, 22, 1),
			new Item(383, 16, 1),
			new Item(383, 19, 1),
			new Item(383, 18, 1),
			new Item(383, 23, 1),
			new Item(383, 24, 1),
			new Item(383, 25, 1),
			new Item(383, 26, 1),
			new Item(383, 27, 1),
			new Item(383, 33, 1),
			new Item(383, 38, 1),
			new Item(383, 39, 1),
			new Item(383, 34, 1),
			new Item(383, 48, 1),
			new Item(383, 46, 1),
			new Item(383, 37, 1),
			new Item(383, 35, 1),
			new Item(383, 32, 1),
			new Item(383, 36, 1),
			new Item(383, 47, 1),
			new Item(383, 17, 1),
			new Item(383, 40, 1),
			new Item(383, 45, 1),
			new Item(383, 49, 1),
			new Item(383, 50, 1),
			new Item(383, 42, 1),
			new Item(383, 41, 1),
			new Item(383, 43, 1),
			new Item(97, 0, 1),
			new Item(97, 1, 1),
			new Item(97, 2, 1),
			new Item(97, 3, 1),
			new Item(97, 4, 1),
			new Item(97, 5, 1),
			new Item(384, 0, 1),
			new Item(385, 0, 1),
			new Item(268, 0, 1),
			new Item(290, 0, 1),
			new Item(269, 0, 1),
			new Item(270, 0, 1),
			new Item(271, 0, 1),
			new Item(272, 0, 1),
			new Item(291, 0, 1),
			new Item(273, 0, 1),
			new Item(274, 0, 1),
			new Item(275, 0, 1),
			new Item(267, 0, 1),
			new Item(292, 0, 1),
			new Item(256, 0, 1),
			new Item(257, 0, 1),
			new Item(258, 0, 1),
			new Item(276, 0, 1),
			new Item(293, 0, 1),
			new Item(277, 0, 1),
			new Item(278, 0, 1),
			new Item(279, 0, 1),
			new Item(283, 0, 1),
			new Item(294, 0, 1),
			new Item(284, 0, 1),
			new Item(285, 0, 1),
			new Item(286, 0, 1),
			new Item(298, 0, 1),
			new Item(299, 0, 1),
			new Item(300, 0, 1),
			new Item(301, 0, 1),
			new Item(302, 0, 1),
			new Item(303, 0, 1),
			new Item(304, 0, 1),
			new Item(305, 0, 1),
			new Item(306, 0, 1),
			new Item(307, 0, 1),
			new Item(308, 0, 1),
			new Item(309, 0, 1),
			new Item(310, 0, 1),
			new Item(311, 0, 1),
			new Item(312, 0, 1),
			new Item(313, 0, 1),
			new Item(314, 0, 1),
			new Item(315, 0, 1),
			new Item(316, 0, 1),
			new Item(317, 0, 1),
			new Item(69, 0, 1),
			new Item(123, 0, 1),
			new Item(76, 0, 1),
			new Item(72, 0, 1),
			new Item(70, 0, 1),
			new Item(147, 0, 1),
			new Item(148, 0, 1),
			new Item(143, 5, 1),
			new Item(77, 5, 1),
			new Item(151, 0, 1),
			new Item(131, 0, 1),
			new Item(356, 0, 1),
			new Item(404, 0, 1),
			new Item(23, 3, 1),
			new Item(125, 3, 1),
			new Item(33, 1, 1),
			new Item(29, 1, 1),
			new Item(251, 0, 1),
			new Item(410, 0, 1),
			new Item(332, 0, 1),
			new Item(409, 0, 1),
			new Item(422, 0, 1),
			new Item(52, 0, 1),
			new Item(116, 0, 1),
			new Item(165, 0, 1),
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 5), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 5), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 5), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 6), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 6), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 6), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 7), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 7), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 7), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 8), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 5) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 5) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 5) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 12), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 12), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 13), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 13), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 14), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 14), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 14), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 5) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 16), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 17), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 17), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 17), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 18), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 18), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 18), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 4) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 5) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 20), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 20), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 21), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 22), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 23), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 23), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 23), new NbtShort("lvl", 3) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 24), new NbtShort("lvl", 1) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 24), new NbtShort("lvl", 2) } } } },
			new Item(403, 0, 1){ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 24), new NbtShort("lvl", 3) } } } },
			new Item(35, 0, 1),
			new Item(35, 8, 1),
			new Item(35, 7, 1),
			new Item(35, 15, 1),
			new Item(35, 12, 1),
			new Item(35, 14, 1),
			new Item(35, 1, 1),
			new Item(35, 4, 1),
			new Item(35, 5, 1),
			new Item(35, 13, 1),
			new Item(35, 9, 1),
			new Item(35, 3, 1),
			new Item(35, 11, 1),
			new Item(35, 10, 1),
			new Item(35, 2, 1),
			new Item(35, 6, 1),
			new Item(171, 0, 1),
			new Item(171, 8, 1),
			new Item(171, 7, 1),
			new Item(171, 15, 1),
			new Item(171, 12, 1),
			new Item(171, 14, 1),
			new Item(171, 1, 1),
			new Item(171, 4, 1),
			new Item(171, 5, 1),
			new Item(171, 13, 1),
			new Item(171, 9, 1),
			new Item(171, 3, 1),
			new Item(171, 11, 1),
			new Item(171, 10, 1),
			new Item(171, 2, 1),
			new Item(171, 6, 1),
			new Item(351, 0, 1),
			new Item(351, 8, 1),
			new Item(351, 7, 1),
			new Item(351, 15, 1),
			new Item(351, 12, 1),
			new Item(351, 14, 1),
			new Item(351, 1, 1),
			new Item(351, 4, 1),
			new Item(351, 5, 1),
			new Item(351, 13, 1),
			new Item(351, 9, 1),
			new Item(351, 3, 1),
			new Item(351, 11, 1),
			new Item(351, 10, 1),
			new Item(351, 2, 1),
			new Item(351, 6, 1),
			new Item(374, 0, 1),
			new Item(373, 0, 1),
			new Item(373, 1, 1),
			new Item(373, 2, 1),
			new Item(373, 3, 1),
			new Item(373, 4, 1),
			new Item(373, 5, 1),
			new Item(373, 6, 1),
			new Item(373, 7, 1),
			new Item(373, 8, 1),
			new Item(373, 9, 1),
			new Item(373, 10, 1),
			new Item(373, 11, 1),
			new Item(373, 12, 1),
			new Item(373, 13, 1),
			new Item(373, 14, 1),
			new Item(373, 15, 1),
			new Item(373, 16, 1),
			new Item(373, 17, 1),
			new Item(373, 18, 1),
			new Item(373, 19, 1),
			new Item(373, 20, 1),
			new Item(373, 21, 1),
			new Item(373, 22, 1),
			new Item(373, 23, 1),
			new Item(373, 24, 1),
			new Item(373, 25, 1),
			new Item(373, 26, 1),
			new Item(373, 27, 1),
			new Item(373, 28, 1),
			new Item(373, 29, 1),
			new Item(373, 30, 1),
			new Item(373, 31, 1),
			new Item(373, 32, 1),
			new Item(373, 33, 1),
			new Item(373, 34, 1),
			new Item(373, 35, 1),
			new Item(373, 36, 1),
			new Item(438, 0, 1),
			new Item(438, 1, 1),
			new Item(438, 2, 1),
			new Item(438, 3, 1),
			new Item(438, 4, 1),
			new Item(438, 5, 1),
			new Item(438, 6, 1),
			new Item(438, 7, 1),
			new Item(438, 8, 1),
			new Item(438, 9, 1),
			new Item(438, 10, 1),
			new Item(438, 11, 1),
			new Item(438, 12, 1),
			new Item(438, 13, 1),
			new Item(438, 14, 1),
			new Item(438, 15, 1),
			new Item(438, 16, 1),
			new Item(438, 17, 1),
			new Item(438, 18, 1),
			new Item(438, 19, 1),
			new Item(438, 20, 1),
			new Item(438, 21, 1),
			new Item(438, 22, 1),
			new Item(438, 23, 1),
			new Item(438, 24, 1),
			new Item(438, 25, 1),
			new Item(438, 26, 1),
			new Item(438, 27, 1),
			new Item(438, 28, 1),
			new Item(438, 29, 1),
			new Item(438, 30, 1),
			new Item(438, 31, 1),
			new Item(438, 32, 1),
			new Item(438, 33, 1),
			new Item(438, 34, 1),
			new Item(438, 35, 1),
			new Item(438, 36, 1),
		};
	}
}