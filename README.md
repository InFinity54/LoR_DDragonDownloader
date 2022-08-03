# _Legends of Runeterra_ - _Data Dragon_ Downloader

Software used to download automatically all available versions of _Data Dragon_ for [_Legends of Runeterra_](https://playruneterra.com) from _Riot Games_' servers. App only available in French for now, but will be fully translated in English in the future.

## Install

```bash
git clone https://github.com/InFinity54/LoR_DDragonDownloader.git LoR_DDragonDownloader
```

## Démarrage

Open file `LoR_DataDragonDownloader.sln` with Visual Studio. The minimal version of [_Visual Studio_](https://visualstudio.microsoft.com) for this project is _Visual Studio 2022_.

## How it work

When the software is started, it will read some JSON settings files, included in the "database" sub-folder of the compiled software. This list is updated by me after each new version of the game.
Note that it can take some time before the file gets updated, because it's a manual process, that depends on _Riot_, and because I'm not playing a lot to this game.

After reading versions list, you'll be ask to choose a download folder. This folder will be saved in the app settings file, and can be edited directly in this settings file or with the app interface.

There are two way of downloading _Data Dragon_'s versions:
* The first one will only download the latest version of _Data Dragon_ for _Legends of Runeterra_.
* The second one will download all existing versions of _Data Dragon_ for _Legends of Runeterra_.

Each of these downloading ways will download each zip files for a version, and extract them into a custom tree structure, which is easier too use in your projects.
You can edit all folders and files, and even delete some of them, when download is finished: they are yours.

In addition, there are two ways of sorting the extracted files after downloading:
* The first one will merge all files in the selected download folder (which will contains two folders, called `data` and `img`, which are those included in zip files from _Riot_'s servers)
* The second one will merge all files in the same way, but in a sub-folder which will be called based on the downloaded set (like `core` or `set1` for example).

## Note for non-French people

Commits are already written in English to prepare a future translation of the code source, which is coming in the next months.