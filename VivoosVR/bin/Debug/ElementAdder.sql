INSERT INTO Core.Consumers (Id, Code, Description, Email)
Values (newid(), 'admin', 'selam', 'admin')

INSERT INTO Core.Companies (Id)
Values ((SELECT id from core.Consumers where Code= 'admin'))

INSERT INTO CORE.Branches (Id, CompanyId)
VALUES ((SELECT id from core.Consumers where Code= 'admin'), (SELECT id from core.Consumers where Code= 'admin'))

INSERT INTO CORE.Groups(Id, BranchId)
VALUES ((SELECT id from core.Consumers where Code= 'admin'), (SELECT id from core.Consumers where Code= 'admin'))

INSERT INTO CORE.Users(Id, GroupId, Password)
VALUES ((SELECT id from core.Consumers where Code= 'admin'), (SELECT id from core.Consumers where Code= 'admin'), 123)

INSERT INTO Core.Consumers (Id, Code, Description, Email)
Values (newid(), 'user', 'selam', 'user')

INSERT INTO Core.Companies (Id)
Values ((SELECT id from core.Consumers where Code= 'user'))

INSERT INTO CORE.Branches (Id, CompanyId)
VALUES ((SELECT id from core.Consumers where Code= 'user'), (SELECT id from core.Consumers where Code= 'user'))

INSERT INTO CORE.Groups(Id, BranchId)
VALUES ((SELECT id from core.Consumers where Code= 'user'), (SELECT id from core.Consumers where Code= 'user'))

INSERT INTO CORE.Users(Id, GroupId, Password)
VALUES ((SELECT id from core.Consumers where Code= 'user'), (SELECT id from core.Consumers where Code= 'user'), 123)