START TRANSACTION;

CREATE TABLE "Users" (
    "Id" uuid NOT NULL,
    "GivenName" text NULL,
    "FamilyName" text NULL,
    "Email" text NULL,
    "DateOfBirth" timestamp with time zone NOT NULL,
    "Address" text NULL,
    CONSTRAINT "PK_Users" PRIMARY KEY ("Id")
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220115202149_AddUserTable', '6.0.1');

COMMIT;