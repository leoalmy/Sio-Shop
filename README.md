# Sio Shop

Application de gestion de ventes, clients et produits pour petits commerces.

## 📋 Description

**Sio Shop** est une application desktop développée en C# avec Windows Forms. Elle permet de gérer efficacement :

- **Clients** : Création, consultation, historique d'achats et régénération de factures
- **Produits** : Gestion du catalogue avec stocks, marques (base de données normalisée), prix
- **Ventes** : Saisie de transactions avec génération de factures PDF
- **Stocks** : Mise à jour via fichiers CSV pour l'administrateur

L'application utilise une base de données MySQL normalisée pour la persistance des données.

## 🛠 Spécifications Techniques

- **Langage** : C# 7.3
- **Framework** : .NET Framework 4.8
- **Interface** : Windows Forms
- **Base de données** : MySQL (Architecture relationnelle)
- **Génération PDF** : QuestPDF (Architecture Fluent)
- **Gestion fichiers** : Support CSV/TXT

## 🚀 Fonctionnalités

### Authentification
- Système de connexion sécurisé avec matricule et mot de passe
- Gestion de session utilisateur
- Rôles différenciés (administrateur `matricule = 0` vs employés)

### Gestion des Produits
- **Consultation du catalogue** : Affichage de tous les produits avec filtrage dynamique par marque
- **Création de produits** : Ajout de nouveaux produits via listes déroulantes sécurisées (clés étrangères)
- **Modification de produits** : Édition des informations existantes
- **Affichage du statut stock** : Indication visuelle "HORS STOCK" pour stock = 0
- **Admin uniquement** : Mise à jour des stocks via fichier CSV avec rapport détaillé

### Gestion des Clients
- Création et modification des informations clients
- Consultation de la liste des clients
- **Historique d'achats** : Visualisation des anciennes commandes depuis la fiche client
- **Régénération PDF** : Création et ouverture instantanée des factures d'anciens achats à la volée

### Gestion des Ventes
- Saisie des transactions avec détails produits et contrôle des stocks
- Calcul automatique de la TVA (20%) et du TTC
- Génération automatique de factures en PDF professionnel
- Archivage par année dans le dossier Documents de l'utilisateur

## 🗂 Structure du Projet

```text
Sio_Shop/
├── Metiers/
│   ├── ProduitManager.cs      # CRUD produits, jointures SQL et gestion CSV
│   ├── ClientManager.cs       # CRUD clients et historique d'achats
│   ├── VenteManager.cs        # Gestion des ventes et MAJ stocks
│   └── FactureManager.cs      # Dessin et génération PDF avec QuestPDF
├── Session.cs                 # Gestion de la session utilisateur
├── Connexion.cs               # Écran d'authentification
├── MainMenu.cs                # Menu principal
├── Produit.cs                 # Gestion des produits (interface)
├── Detail_Produit.cs          # Création/modification de produit
├── Client.cs                  # Gestion des clients (interface)
├── Detail_Client.cs           # Fiche client, historique et factures
├── Vente.cs                   # Saisie de ventes (interface)
└── Program.cs                 # Point d'entrée
```

## 🔧 Installation et Configuration

### Prérequis
- Visual Studio 2022 ou supérieur
- .NET Framework 4.8
- MySQL Server 5.7+
- NuGet Package Manager

### Dépendances NuGet
- `MySql.Data` (Connecteur MySQL)
- `QuestPDF` (Génération de factures PDF modernes)

### Configuration Base de Données
1. Créer une base de données MySQL nommée `sio_shop`
2. Créer les tables relationnelles nécessaires :
   - `marque` (id_marque, nom_marque)
   - `produit` (reference, id_marque, nom, prix, stock)
   - `client` (Num_client, nom, prenom, adresse, mail, tel)
   - `pdt_achete` (id_achat, Num_client, REFERENCE, date_achat)
3. Configurer la chaîne de connexion dans la classe `MySQL`

### Lancement
1. Ouvrir le projet dans Visual Studio
2. Restaurer les packages NuGet
3. Compiler et exécuter (F5) ou générer la version `Release`
4. Identifiants de test : matricule `0` pour admin

## 💻 Utilisation

### Authentification
- Entrer un **matricule** (numéro employé) et un **mot de passe**
- Accès administrateur avec matricule **0** (bouton "Maj Stock" visible)
- Employé normal : accès aux consultation et saisie uniquement

### Gestion des Produits
- Vue tableau avec filtrage par marque et alertes visuelles sur les stocks.
- Modification / Création via la fiche produit.

### Mise à Jour des Stocks (Admin)
1. Préparer un fichier CSV (voir format ci-dessous).
2. Cliquer sur le bouton **"Maj Stock"** (visible uniquement pour admin).
3. Sélectionner le fichier CSV/TXT.
4. L'application affiche un rapport (succès et erreurs) et recharge le tableau.

## 📄 Formats de Fichiers

### Format CSV Stocks

**Séparateur point-virgule :**
```csv
Reference;Quantité
PROD001;50
PROD002;30
PROD003;100
```
*(L'en-tête est ignorée automatiquement. Les quantités s'additionnent aux stocks existants).*

## 📦 Arborescence des Factures

Les factures PDF sont générées dynamiquement dans :

```text
C:/Users/[Utilisateur]/Documents/
└── Sio Shop/
    └── Factures_2026/
        ├── Facture_0001_Jean_Dupont.pdf
        ├── Facture_0002_Marie_Martin.pdf
        └── ...
```

## 🔐 Sécurité & Ergonomie (UX/UI)

- **Injection SQL** : Utilisation exclusive de paramètres SQL (`@param`).
- **DataBinding** : Utilisation de `DisplayMember` et `ValueMember` pour lier les ID (clés primaires) aux listes déroulantes de manière invisible.
- **Gestion des erreurs UI** : Désactivation du `MultiSelect` sur les tableaux et grisage dynamique des boutons (ex: "Voir facture") si aucune ligne n'est sélectionnée.
- **Rôles** : Fonctionnalités sensibles (Maj Stock) réservées aux admins.

## 💡 Particularités Techniques

### Managers & Base de données
- **Architecture Normalisée** : Séparation des marques dans une table dédiée.
- **Jointures SQL** : Utilisation massive d'`INNER JOIN` pour rapatrier les noms de marques et les détails d'historiques.
- **ObtenirToutesLesMarques()** : Alimente dynamiquement les listes déroulantes depuis la BDD.
- **MettreAJourStockDepuisCSV()** : Parse CSV + requêtes UPDATE avec compteur de succès/erreurs.

### Conversion Décimales
Les prix saisis avec virgule (1,50€) sont automatiquement convertis en point (1.50) pour la base de données SQL.

### Gestion des Changements de Page
La variable `_changementDePage` empêche les demandes de confirmation inutiles lors de la navigation entre pages.

## 📝 Notes de Développement

- Commentaires en français dans le code pour faciliter la maintenance.
- Code structuré avec pattern **Manager** pour les accès données (DAL).
- Gestion erreurs centralisée avec `MessageBox`.

## 🧪 Checklist de Test

- [ ] Admin : Bouton "Maj Stock" visible
- [ ] Création produit : Ajout fonctionnel avec sélection de l'ID Marque
- [ ] Stock = 0 : Affichage "HORS STOCK" coloré
- [ ] CSV : Import avec rapport correct
- [ ] Historique Client : Les anciens achats s'affichent correctement
- [ ] Factures : Génération et ouverture du PDF fonctionnelles

## 📚 Ressources

- [Connecteur MySQL .NET](https://dev.mysql.com/doc/connector-net/en/)
- [QuestPDF Documentation](https://www.questpdf.com/documentation.html)
- [Windows Forms Best Practices](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)

## ⚖️ Licence

Copyright © 2026 - Sio Shop

---

**Dépôt GitHub** : https://github.com/leoalmy/Sio-Shop

Pour toute question ou problème, consulter le code source détaillé et les commentaires inline.