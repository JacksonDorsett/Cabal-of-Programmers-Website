CREATE TABLE IF NOT EXISTS Project(
    id serial Primary Key,
    name varchar,
    description varchar,
    datePosted TimeStamp,
    repoLink varchar,
    imgLink varchar
);


INSERT INTO Project(id, name, description, datePosted, repoLink, imgLink)
VALUES (default, 'Nail: Programming Language', 'Safely-typed scripting language written in Rust. Nail itself has been inspired by Rust but does not include the low-level functionality. However, what the language lacks in low-level functionality, it makes up for it in its ease of use and readability.', NOW(), 'https://github.com/HARDIntegral/Nail','https://user-images.githubusercontent.com/73722314/116011990-d68bf880-a5f5-11eb-8aca-0064b93ba2ac.png');