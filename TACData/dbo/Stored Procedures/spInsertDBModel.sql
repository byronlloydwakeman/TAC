CREATE PROCEDURE [dbo].[spInsertDBModel]
	@MinHealth int,
	@MinMana int,
	@Armor NVARCHAR(20),
	@Accessories NVARCHAR(20),
	@Mount NVARCHAR(20),
	@Minions NVARCHAR(20),
	@Grapple NVARCHAR(20),
	@Potions NVARCHAR(50),
	@Buffs NVARCHAR(50),
	@Weapons NVARCHAR(100),
	@Boss NVARCHAR(20),
	@Moves NVARCHAR(MAX),
	@Timing NVARCHAR(MAX)
AS
begin
	insert into AutoClickModels(MinHealth, MinMana, Armor, Accessories, Mount, Minions, Grapple, Potions, Buffs, Weapons, Boss, Moves, Timing)
	values (@MinHealth, @MinMana, @Armor, @Accessories, @Mount, @Minions, @Grapple, @Potions, @Buffs, @Weapons, @Boss, @Moves, @Timing)
end
