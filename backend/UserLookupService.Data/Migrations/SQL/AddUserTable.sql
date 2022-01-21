CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    migration_id character varying(150) NOT NULL,
    product_version character varying(32) NOT NULL,
    CONSTRAINT pk___ef_migrations_history PRIMARY KEY (migration_id)
);

START TRANSACTION;

CREATE TABLE users (
    id uuid NOT NULL,
    given_name text NULL,
    family_name text NULL,
    email text NULL,
    date_of_birth timestamp with time zone NOT NULL,
    address text NULL,
    CONSTRAINT pk_users PRIMARY KEY (id)
);

INSERT INTO "__EFMigrationsHistory" (migration_id, product_version)
VALUES ('20220121011205_AddUserTable', '6.0.1');

COMMIT;