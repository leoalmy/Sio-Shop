# Sio Shop

Application de gestion de ventes, clients et produits pour petits commerces.

## 📋 Description

**Sio Shop** est une application desktop développée en C# avec Windows Forms. Elle permet de gérer efficacement :

- **Clients** : Création, consultation, historique d'achats et régénération de factures.
- **Produits & Marques** : Gestion du catalogue avec stocks, marques (base de données normalisée), et prix.
- **Ventes** : Saisie de transactions avec génération de factures PDF.
- **Tableau de Bord** : Vue d'ensemble interactive avec statistiques au survol et graphiques d'analyse.
- **Stocks** : Mise à jour via fichiers CSV pour l'administrateur.

L'application utilise une base de données MySQL normalisée (hébergée localement via XAMPP) pour la persistance des données.

## 🛠 Spécifications Techniques

- **Langage** : C# 7.3
- **Framework** : .NET Framework 4.8
- **Interface** : Windows Forms (avec `DataVisualization.Charting` pour les graphiques)
- **Base de données** : MySQL via XAMPP (Architecture relationnelle)
- **Sécurité** : Hachage BCrypt, fichier `.env` et séparation des privilèges SQL
- **Génération PDF** : QuestPDF (Architecture Fluent)
- **Gestion fichiers** : Support CSV/TXT

## 🚀 Fonctionnalités

### Sécurité & Authentification
- Système de connexion sécurisé avec matricule et mot de passe (hachés via **BCrypt**).
- Chargement des variables d'environnement via un fichier `.env`.
- **Moindre privilège SQL** : Utilisation de deux comptes BDD distincts (un compte restreint pour le login, un compte applicatif pour le contenu).
- Rôles différenciés (administrateur `matricule = 0` vs employés).

### Interface & Expérience Utilisateur (UX/UI)
- **Tableau de bord interactif (Dashboard)** : Statistiques générées à la volée au survol des menus (chiffre d'affaires, clients totaux, ruptures de stock) et graphique "Top 5 des Marques".
- **Dark Mode Persistant** : Thème sombre/clair applicable à toute l'application via un algorithme récursif, avec sauvegarde des préférences locales (`Properties.Settings`).
- Design ergonomique avec boutons arrondis (`GraphicsPath`) et indicateurs visuels.

### Gestion des Produits & Marques
- **Consultation du catalogue** : Affichage de tous les produits avec filtrage dynamique par marque.
- **Création/Modification** : Ajout de nouveaux produits via listes déroulantes sécurisées (clés étrangères liées aux marques).
- **Affichage du statut stock** : Indication visuelle "HORS STOCK" pour stock = 0.
- **Admin uniquement** : Mise à jour des stocks via fichier CSV avec rapport détaillé (succès/erreurs).

### Gestion des Clients
- Création et modification des informations clients.
- Consultation de la liste des clients.
- **Historique d'achats** : Visualisation des anciennes commandes depuis la fiche client.
- **Régénération PDF** : Création et ouverture instantanée des factures d'anciens achats à la volée.

### Gestion des Ventes
- Saisie des transactions avec détails produits et contrôle instantané des stocks.
- Calcul automatique de la TVA (20%) et du TTC.
- Génération automatique de factures en PDF professionnel.
- Archivage organisé par année dans le dossier Documents de l'utilisateur.

## 🗂 Structure du Projet

```text
Sio_Shop/
├── Metiers/
│   ├── ProduitManager.cs      # CRUD produits, jointures SQL et gestion CSV
│   ├── ClientManager.cs       # CRUD clients et historique d'achats
│   ├── VenteManager.cs        # Gestion des ventes, requêtes CA et MAJ stocks
│   ├── MarqueManager.cs       # CRUD et alimentation dynamique des listes déroulantes
│   ├── EmployeManager.cs      # Connexion et vérification BCrypt
│   ├── FactureManager.cs      # Dessin et génération PDF avec QuestPDF
│   └── ThemeManager.cs        # Algorithme récursif du Dark Mode
├── Properties/
│   └── Settings.settings      # Sauvegarde des préférences utilisateur (ex: Thème)
├── Session.cs                 # Gestion de la session utilisateur
├── Connexion.cs               # Écran d'authentification
├── MainMenu.cs                # Menu principal et Dashboard (Hover & Graphiques)
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
- **XAMPP** (pour le serveur MySQL local)
- NuGet Package Manager

### Dépendances NuGet
- `MySql.Data` (Connecteur MySQL)
- `QuestPDF` (Génération de factures PDF modernes)
- `BCrypt.Net-Next` (Hachage sécurisé des mots de passe)

### Configuration Base de Données (XAMPP)
1. Lancer **Apache** et **MySQL** depuis le panneau de contrôle XAMPP.
2. Ouvrir phpMyAdmin (`http://localhost/phpmyadmin`) et créer une base de données nommée `db_sioshop1`.
3. Importer le fichier SQL fourni ou créer les tables relationnelles nécessaires (`marque`, `produit`, `client`, `pdt_achete`, `employe`).
4. Créer à la racine de l'application un fichier `.env` contenant vos chaînes de connexion (compte login et compte applicatif).

### Lancement
1. Ouvrir le projet dans Visual Studio.
2. Restaurer les packages NuGet.
3. Compiler et exécuter (F5) ou générer la version `Release`.
4. Identifiants de test : login `admin`, matricule `0`.

## 💻 Utilisation

### Authentification & Rôles
- Accès administrateur avec matricule **0** (bouton "Maj Stock" visible).
- Employé normal : accès aux consultation et saisie uniquement.

### Mise à Jour des Stocks (Admin)
1. Préparer un fichier CSV.
2. Cliquer sur le bouton **"Maj Stock"** (visible uniquement pour admin).
3. Sélectionner le fichier CSV/TXT. L'application affiche un rapport (succès et erreurs) et recharge le tableau.

### Paramétrage de l'interface
- Cliquez sur l'icône **Lune/Soleil** du menu principal pour basculer entre le mode clair et le mode sombre. Ce paramètre est sauvegardé automatiquement pour vos prochaines sessions.
- Survolez les boutons du menu latéral pour voir les statistiques s'actualiser en temps réel sur le tableau de bord.

## 📄 Formats de Fichiers

### Format CSV Stocks
**Séparateur point-virgule :**
```csv
Reference;Quantité
PROD001;50
PROD002;30
```
*(L'en-tête est ignorée automatiquement. Les quantités s'additionnent aux stocks existants).*

## 📦 Arborescence des Factures

Les factures PDF sont générées dynamiquement dans :

```text
C:/Users/[Utilisateur]/Documents/
└── Sio Shop/
    └── Factures_202X/
        ├── Facture_0001_Jean_Dupont.pdf
        └── ...
```

## 🔐 Sécurité & Ergonomie (UX/UI)

- **Séparation des privilèges** : Double compte SQL pour restreindre l'accès en cas de compromission.
- **Injection SQL** : Utilisation exclusive de requêtes préparées (`@param`).
- **DataBinding** : Utilisation de `DisplayMember` et `ValueMember` pour lier les ID (clés primaires) de manière invisible.
- **Récursivité UI** : Changement global du thème (`ThemeManager`) par exploration dynamique des composants enfants.

## 💡 Particularités Techniques

### Managers & Base de données
- **Architecture Normalisée** : Séparation stricte des marques, produits, employés et clients.
- **Jointures SQL** : Utilisation massive d'`INNER JOIN` pour rapatrier les informations croisées (Historiques, Top Marques).
- **Exécution Scalaire** : Utilisation de `ExecuteScalar()` pour l'optimisation des requêtes de comptage du Dashboard.

## 🧪 Checklist de Test

- [ ] Connexion : Rejet des mauvais mots de passe via vérification BCrypt.
- [ ] Interface : Le Dark Mode reste actif après la fermeture/réouverture de l'application.
- [ ] Dashboard : Les statistiques s'affichent au survol de la souris.
- [ ] Dashboard : Le graphique des ventes se génère avec les bonnes données.
- [ ] Admin : Bouton "Maj Stock" visible.
- [ ] CSV : Import avec incrémentation correcte en BDD.
- [ ] Factures : Génération et ouverture instantanée du PDF.

## 📚 Ressources

- [Connecteur MySQL .NET](https://dev.mysql.com/doc/connector-net/en/)
- [QuestPDF Documentation](https://www.questpdf.com/documentation.html)
- [Microsoft Chart Controls](https://learn.microsoft.com/en-us/previous-versions/dd456632(v=vs.140))

## ⚖️ Licence

Copyright © 2026 - Sio Shop

---

**Dépôt GitHub** : https://github.com/leoalmy/Sio-Shop

Pour toute question ou problème, consulter le code source détaillé et les commentaires inline.