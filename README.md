# _Legends of Runeterra_ - _Data Dragon_ Downloader

Logiciel permettant de télécharger automatiquement toutes les versions du _Data Dragon_ de _Legends of Runeterra_ depuis les serveurs de Riot Games. Disponible uniquement en français pour le moment.

## Installation

```bash
git clone https://github.com/InFinity54/LoR_DataDragonDownloader.git LoR_DataDragonDownloader
```

## Démarrage

Ouvrir le fichier _LoR_DataDragonDownloader.sln_ avec Visual Studio.

## Fonctionnement

Une fois le programme démarré, il récupère, depuis ce dépôt Git, la liste des versions de _Legends of Runeterra_ grâce à un fichier JSON, mise à jour par mes soins à chaque nouvelle version. Notez qu'il est possible qu'il y ait quelques heures ou jours de délai entre la sortie de la version et son intégration au fichier JSON, puisque je ne suis pas un grand joueur de ce jeu (bien que je l'apprécie).

Une fois les versions récupérées en mémoire, si vous n'avez jamais démarré le programme, il vous invite à choisir le dossier de téléchargement du _Data Dragon_. Il est stocké dans un fichier de configuration dans le dossier du programme, et peut être changé manuellement directement depuis ce fichier ou par l'intermédiaire des paramètres directement dans le logiciel.

Il existe deux modes de fonctionnement, qui sont automatiques :
- Le premier mode consiste à télécharger l'intégralité du _Data Dragon_ concernant la dernière version publiée du jeu.
- Le second mode consiste à télécharger l'intégralité du _Data Dragon_ de toutes les versions publiées du jeu, depuis la version 1.0.0.

Quel que soit le mode sélectionné, chaque version est divisée en plusieurs dizaines de dossiers compressés au format ZIP. Le programme se charge de les extraire afin de créer une arborescence précise, qui facilite l'utilisation du Data Dragon. Le programme se charge également de supprimer certains fichiers inutiles et d'en générer d'autres qui peuvent être utiles. Libre à vous de modifier les dossiers et fichiers téléchargés, ou même d'en supprimer une partie.

## Note

Comme je n'exclus pas de traduire le programme, les commits seront écrits en anglais, bien que le contenu du dépôt soit en français dès que cela est possible pour le moment.