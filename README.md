# Esculape-C#

Projet annuel de C#

Tâches restantes :

-Mise en place du calendrier

-Gestion des créneaux

-Modification et suppression des créneaux

Scripts SQL :

CREATE DATABASE IF NOT EXISTS esculape

CREATE TABLE medecins
(
    mssnumber INT PRIMARY KEY NOT NULL,
    mname VARCHAR(20),
    msurname VARCHAR(20),
    mregisterdate VARCHAR(20),
    
)

CREATE TABLE patients
(
    id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name VARCHAR(20),
    surname VARCHAR(20),
    bday VARCHAR(20),
    ssnumber VARCHAR(50),
    
)

CREATE TABLE user_account
(
    ssnumber INT PRIMARY KEY NOT NULL,
    user_name VARCHAR(20),
    password VARCHAR(20),
    category VARCHAR(20),
    
)
