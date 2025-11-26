# Boutique Diayma
# TP Débogage C# et Technologies .NET
**Université Cheikh Anta Diop - ESP Dakar**  
**Étudiant :** Zeinebou El Wely CHEIKH ABD EDAIM 
**Date :** Novembre 2025

---

##  Informations Générales du Projet

### Projets de la Solution
La solution contient les projets suivants :
- **Diayma** (projet principal web)

### : Version SDK .NET Utilisée
- **Version SDK :** .NET [netcoreapp2.0]
- **Framework cible :** net6.0 / net7.0 / net8.0 
---

## Bugs Identifiés

### Introduction
Cette section documente le parcours d'exécution du code depuis 
le démarrage de l'application jusqu'à l'affichage de la page des produits dans le navigateur.

---

### Point d'Arrêt 1 : Startup.cs (ligne 20)

**Informations :**
- **Fichier :** Startup.cs
- **Namespace :** P2FixAnAppDotNetCode 
- **Classe :** Startup
- **Méthode :** `Startup(IConfiguration configuration)`
- **Ligne :** 20

**Description :**
Ce point d'arrêt est atteint lors du démarrage de l'application. La méthode Startup initialise la configuration de l'application.


**Pile des appels (Call Stack) :**
```
1. Diayma.dll!P2FixAnAppDotNetCode.Startup.Startup(IConfiguration configuration)
2. Diayma.dll!P2FixAnAppDotNetCode.Program.BuildWebHost(string[] args)
3. Diayma.dll!P2FixAnAppDotNetCode.Program.Main(string[] args)
```

---

### Point d'Arrêt 2 : ProductController.cs (ligne 15)

**Informations :**
- **Fichier :** ProductController.cs
- **Namespace :** P2FixAnAppDotNetCode.Controllers
- **Classe :** ProductController
- **Méthode :** ProductController(IProductService productService, ILanguageService languageService)
- **Ligne :** 15


**Pile des appels (Call Stack) :**
```
 Diayma.dll!P2FixAnAppDotNetCode.Startup.Startup(Microsoft.Extensions.Configuration.IConfiguration configuration) Ligne 21	C#
 Diayma.dll!P2FixAnAppDotNetCode.Program.BuildWebHost(string[] args) Ligne 14	C#
 Diayma.dll!P2FixAnAppDotNetCode.Program.Main(string[] args) Ligne 10	C#

```

---

### Point d'Arrêt 3 : CartController.cs (ligne 15)

**Informations :**
- **Fichier :** CartController.cs
- **Namespace :** [À compléter]
- **Classe :** CartController
- **Méthode :** [À compléter]
- **Ligne :** 15

**Description :**
[Si ce point n'est PAS atteint lors de l'affichage des produits, notez : "Ce point d'arrêt n'a pas été atteint lors de l'affichage de la page d'accueil. Il est probablement appelé lors d'actions sur le panier."]

---

### Point d'Arrêt 4 : OrderController.cs (ligne 17)

**Informations :**
- **Fichier :** OrderController.cs
- **Namespace :** [À compléter]
- **Classe :** OrderController
- **Méthode :** [À compléter]
- **Ligne :** 17

**Description :**
[Même principe - notez si ce point est atteint ou non]

---

### Point d'Arrêt 5 : CartSummaryViewComponent.cs (ligne 12)

**Informations :**
- **Fichier :** CartSummaryViewComponent.cs
- **Namespace :** 
- **Classe :** CartSummaryViewComponent
- **Méthode :** 
- **Ligne :** 12

**Description :**
Ce composant est probablement responsable de l'affichage du résumé du panier dans l'interface.

**Variables observées :**
- [Variables liées au panier]



