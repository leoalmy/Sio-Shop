Application de gestion de ventes, clients et produits pour petits commerces.

## 📋 Description

**Sio Shop** est une application desktop développée en C# avec Windows Forms. Elle permet de gérer efficacement :

- **Clients** : Création, consultation et gestion des informations clients
- **Produits** : Gestion du catalogue avec stocks, marques, prix
- **Ventes** : Saisie de transactions avec génération de factures PDF
- **Stocks** : Mise à jour via fichiers CSV pour l'administrateur

L'application utilise une base de données MySQL pour la persistance des données.

## 🛠 Spécifications Techniques

- **Langage** : C# 7.3
- **Framework** : .NET Framework 4.8
- **Interface** : Windows Forms
- **Base de données** : MySQL
- **Génération PDF** : QuestPDF

## 🚀 Fonctionnalités

### Authentification
- Système de connexion sécurisé avec login et mot de passe
- Gestion de session utilisateur
- Rôles différenciés (administrateur vs employés)

### Gestion des Produits
- Consultation du catalogue avec filtrage par marque
- Création de nouveaux produits
- Modification des produits existants
- Affichage du statut stock (normal ou "HORS STOCK")
- **Admin uniquement** : Mise à jour des stocks via fichier CSV

### Gestion des Clients
- Création et modification des informations clients
- Consultation de la liste des clients

### Gestion des Ventes
- Saisie des transactions
- Génération automatique de factures en PDF
- Archivage par année dans le dossier Documents de l'utilisateur

## 🗂 Structure du Projet

Sio_Shop/
├── Metiers/
│   ├── ProduitManager.cs      # Opérations CRUD produits et CSV
│   ├── ClientManager.cs        # Gestion des clients
│   ├── VenteManager.cs         # Gestion des ventes
│   └── FactureManager.cs       # Génération de factures PDF
├── Session.cs                  # Gestion de la session utilisateur
├── Connexion.cs                # Écran d'authentification
├── MainMenu.cs                 # Menu principal
├── Produit.cs                  # Gestion des produits
├── Detail_Produit.cs           # Création/modification de produit
├── Client.cs                   # Gestion des clients
├── Vente.cs                    # Saisie de ventes
└── Program.cs                  # Point d'entrée

## 🔧 Installation et Configuration

### Prérequis
- Visual Studio 2022 ou supérieur
- .NET Framework 4.8
- MySQL Server
- NuGet Package Manager

### Dépendances NuGet
- `MySql.Data` : Connecteur MySQL
- `QuestPDF` : Génération de factures PDF

### Configuration Base de Données

1. Créer une base de données MySQL nommée `sio_shop`
2. Créer les tables nécessaires (produit, client, vente, etc.)
3. Configurer la chaîne de connexion dans la classe `MySQL`

### Lancement
1. Ouvrir le projet dans Visual Studio
2. Restaurer les packages NuGet
3. Compiler et exécuter (F5)

## 💻 Utilisation

### Authentification
- Entrer un matricule et un mot de passe
- Accès administrateur avec matricule **0**

### Interface Principale
Le menu offre 4 options :
1. **Saisir une vente** - Nouvelle transaction
2. **Gestion des clients** - CRUD clients
3. **Gestion des produits** - CRUD produits + stocks
4. **Déconnexion** - Retour à l'écran de connexion

### Mise à Jour des Stocks (Admin)
1. Préparer un fichier CSV avec les colonnes : `Reference;Quantité`
2. Dans la section Produits, cliquer sur "Maj Stock"
3. Sélectionner le fichier CSV
4. L'application met à jour automatiquement les stocks

## 📄 Formats de Fichiers

### Format CSV Stocks
Reference;Quantité
PROD001;50
PROD002;30

Ou avec virgules :
Reference,Quantité
PROD001,50

## 📦 Arborescence des Factures

Les factures PDF sont générées dans :
Documents/
└── Sio Shop/
    └── Factures_2026/
        ├── Facture_0001_Jean_Dupont.pdf
        └── Facture_0002_Marie_Martin.pdf

## 🔐 Sécurité

- Utilisation de paramètres SQL pour prévenir les injections
- Gestion de session pour le contrôle d'accès
- Distinction admin/employé pour les fonctionnalités sensibles

## 📝 Notes de Développement

- Commentaires en français dans le code pour faciliter la maintenance
- Code structuré avec pattern Manager pour les accès données
- Gestion des erreurs avec MessageBox pour feedback utilisateur
- Conversion automatique des décimales (virgule → point) pour SQL

## ⚖️ Licence

Copyright © 2026 - Sio Shop

---

Pour toute question ou problème, consulter le code source détaillé et les commentaires inline.