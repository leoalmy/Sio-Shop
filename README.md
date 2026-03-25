# Sio Shop

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
- **Gestion fichiers** : Support CSV/TXT

## 🚀 Fonctionnalités

### Authentification
- Système de connexion sécurisé avec matricule et mot de passe
- Gestion de session utilisateur
- Rôles différenciés (administrateur `matricule = 0` vs employés)

### Gestion des Produits
- **Consultation du catalogue** : Affichage de tous les produits avec filtrage par marque
- **Création de produits** : Ajout de nouveaux produits avec référence, marque, nom, prix et stock
- **Modification de produits** : Édition des informations existantes
- **Affichage du statut stock** : Indication visuelle "HORS STOCK" pour stock = 0
- **Recherche** : Filtrage par nom de produit ou marque
- **Admin uniquement** : Mise à jour des stocks via fichier CSV avec rapport détaillé

### Gestion des Clients
- Création et modification des informations clients
- Consultation de la liste des clients

### Gestion des Ventes
- Saisie des transactions avec détails produits
- Génération automatique de factures en PDF professionnel
- Archivage par année dans le dossier Documents de l'utilisateur

## 🗂 Structure du Projet


Sio_Shop/
├── Metiers/
│   ├── ProduitManager.cs      # CRUD produits et gestion CSV
│   ├── ClientManager.cs       # CRUD clients
│   ├── VenteManager.cs        # Gestion des ventes
│   └── FactureManager.cs      # Génération PDF avec QuestPDF
├── Session.cs                 # Gestion de la session utilisateur
├── Connexion.cs               # Écran d'authentification
├── MainMenu.cs                # Menu principal
├── Produit.cs                 # Gestion des produits (interface)
├── Detail_Produit.cs          # Création/modification de produit
├── Client.cs                  # Gestion des clients (interface)
├── Vente.cs                   # Saisie de ventes (interface)
└── Program.cs                 # Point d'entrée

## 🔧 Installation et Configuration

### Prérequis
- Visual Studio 2022 ou supérieur
- .NET Framework 4.8
- MySQL Server 5.7+
- NuGet Package Manager

### Dépendances NuGet

MySql.Data      (Connecteur MySQL)
QuestPDF        (Génération de factures PDF)

### Configuration Base de Données

1. Créer une base de données MySQL nommée `sio_shop`
2. Créer les tables nécessaires :
   - `produit` (reference, marque, nom, prix, stock)
   - `client` (informations client)
   - `vente` (transactions)
3. Configurer la chaîne de connexion dans la classe `MySQL`

### Lancement
1. Ouvrir le projet dans Visual Studio
2. Restaurer les packages NuGet
3. Compiler et exécuter (F5)
4. Identifiants de test : matricule `0` pour admin

## 💻 Utilisation

### Authentification
- Entrer un **matricule** (numéro employé) et un **mot de passe**
- Accès administrateur avec matricule **0** (bouton "Maj Stock" visible)
- Employé normal : accès aux consultation et saisie uniquement

### Interface Principale
Le menu offre 4 options :
1. **Saisir une vente** - Nouvelle transaction client
2. **Gestion des clients** - Création/modification clients
3. **Gestion des produits** - CRUD produits + stocks
4. **Déconnexion** - Retour à l'écran de connexion

### Gestion des Produits

#### Consultation
- Vue tableau avec : Référence | Marque | Nom | Prix | Stock
- Filtrage dynamique par marque (liste déroulante)
- Stock = 0 → Affichage "HORS STOCK" avec coloration
- Clic sur une ligne → Ouverture fiche produit

#### Création de Produit
1. Cliquer sur "Nouveau produit"
2. Remplir : Référence (obligatoire), Marque, Nom (obligatoire), Prix, Stock
3. Sauvegarder → Ajout en base de données

#### Modification de Produit
1. Cliquer sur un produit dans le tableau
2. Référence en lecture seule (identifiant unique)
3. Modifier les autres champs
4. Sauvegarder → Update en base de données

#### Mise à Jour des Stocks (Admin)
1. Préparer un fichier CSV (voir format ci-dessous)
2. Cliquer sur le bouton **"Maj Stock"** (visible uniquement pour admin)
3. Sélectionner le fichier CSV/TXT
4. L'application affiche un rapport :
   - ✅ Nombre de produits mis à jour
   - ❌ Nombre de références introuvables
5. Le tableau se recharge automatiquement

## 📄 Formats de Fichiers

### Format CSV Stocks

```
**Séparateur point-virgule :**
Reference;Quantité
PROD001;50
PROD002;30
PROD003;100

**Séparateur virgule :**
Reference,Quantité
PROD001,50
PROD002,30
```

**Caractéristiques :**
- L'en-tête (première ligne) est ignorée automatiquement
- Les lignes vides sont ignorées
- Les références inconnues génèrent une erreur
- Les stocks s'ajoutent aux quantités existantes : `stock = stock + quantité`

### Exemple de Rapport CSV


```
Fichier : livraison_mars_2026.csv
Résultat :
✅ 45 produits mis à jour
❌ 3 références inconnues
```

## 📦 Arborescence des Factures

Les factures PDF sont générées dans :

```
Documents/
└── Sio Shop/
    └── Factures_2026/
        ├── Facture_0001_Jean_Dupont.pdf
        ├── Facture_0002_Marie_Martin.pdf
        └── ...
```
**Contenu facture :**
- En-tête : Logo "SIO SHOP" + adresse
- Numéro facture unique et date
- Détails produits achetés
- Calcul TTC avec TVA
- Signature client

## 🔐 Sécurité

- **Injection SQL** : Utilisation exclusive de paramètres SQL (`@param`)
- **Session utilisateur** : Gestion des accès selon les rôles
- **Contrôle d'accès** : Fonctionnalités sensibles (Maj Stock) réservées aux admins
- **Gestion erreurs** : Messages d'erreur BDD sans exposition de données sensibles
- **Validation input** : Contrôle des champs obligatoires

## 💡 Particularités Techniques

### ProduitManager
- **ObtenirTousLesProduits()** : Recherche LIKE sur nom et marque
- **ObtenirProduitParRef()** : Récupération fiche produit unique
- **AjouterProduit()** : Insertion avec conversion virgule → point
- **ModifierProduit()** : Update ciblée par référence
- **ObtenirToutesLesMarques()** : Liste DISTINCT sans doublons
- **MettreAJourStockDepuisCSV()** : Parse CSV + UPDATE massif avec rapport

### Conversion Décimales
Les prix saisis avec virgule (1,50€) sont automatiquement convertis en point (1.50) pour la base de données SQL.

### Gestion des Changements de Page
Variable `_changementDePage` empêche les demandes de confirmation inutiles lors de la navigation entre pages.

## 📝 Notes de Développement

- Commentaires en français dans le code pour faciliter la maintenance
- Code structuré avec pattern **Manager** pour les accès données (DAL)
- Gestion erreurs centralisée avec `MessageBox`
- DataTable pour les requêtes SELECT (flexibilité)
- MySqlCommand pour les INSERT/UPDATE/DELETE (sécurité)
- Support UTF-8 pour les accents et caractères spéciaux

## 🧪 Checklist de Test

- [ ] Admin : Bouton "Maj Stock" visible
- [ ] Employé : Bouton "Maj Stock" masqué
- [ ] Création produit : Référence + Nom obligatoires
- [ ] Modification : Référence en lecture seule
- [ ] Stock = 0 : Affichage "HORS STOCK" coloré
- [ ] CSV : Import avec rapport correct
- [ ] Factures : Génération PDF dans Documents/Sio Shop/

## 📚 Ressources

- [Connecteur MySQL .NET](https://dev.mysql.com/doc/connector-net/en/)
- [QuestPDF Documentation](https://www.questpdf.com/documentation.html)
- [Windows Forms Best Practices](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)

## ⚖️ Licence

Copyright © 2026 - Sio Shop

---

**Dépôt GitHub** : https://github.com/leoalmy/Sio-Shop

Pour toute question ou problème, consulter le code source détaillé et les commentaires inline.