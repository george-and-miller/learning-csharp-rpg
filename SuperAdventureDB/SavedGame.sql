CREATE TABLE [dbo].[SavedGame]
(
	[CurrentHitPoints] INT NOT NULL,
	[MaximumHitPoints] INT NOT NULL, 
    [Gold] INT NOT NULL, 
    [ExperiencePoints] INT NOT NULL, 
    [CurrentLocationID] INT NOT NULL
) ON [PRIMARY]

GO