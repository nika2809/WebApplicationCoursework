CREATE TABLE [dbo].[Projects] (
    [ProjectID]               INT            IDENTITY (1, 1) NOT NULL,
    [ProjectName]             NVARCHAR (MAX) NOT NULL,
    [CooperationOrganization] NVARCHAR (MAX) NOT NULL,
    [ProjectDetails]          NVARCHAR (MAX) NOT NULL,
    [MemberID]                INT            NOT NULL,
    CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED ([ProjectID] ASC),
    CONSTRAINT [FK_Projects_TeamMembers_MemberID] FOREIGN KEY ([MemberID]) REFERENCES [dbo].[TeamMembers] ([MemberID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Projects_MemberID]
    ON [dbo].[Projects]([MemberID] ASC);

