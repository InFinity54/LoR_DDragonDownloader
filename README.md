# _Legends of Runeterra_ - _Data Dragon_ Downloader

Software used to download automatically all available versions of _Data Dragon_ for [_Legends of Runeterra_](https://playruneterra.com) from _Riot Games_' servers. App only available in French for now, but will be fully translated in English in the future.

## About the app

### Why this software?

I made [some repositories for _Legends of Runeterra_'s _Data Dragon_](https://github.com/InFinity54/LoR_DDragon). These repositories contains more than 50 Gb of data (and it slowly grows after each new patch), which can be hard to download from GitHub or with Git.

To make this process a bit easier, the _Data Dragon_ Downloader has been created. It's able to download the entire _Data Dragon_ for _Legends of Runeterra_ (for all existing versions of the game), or only the latest version, from _Riot_'s servers. This download process is fully automated.

### How it work

When the software is started, it will read some JSON settings files, from this repository. A network connection is required because of that point. This list is updated after each new version of the game.
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

### Multi-language system

The app is translated in French and English. You can change the language used by this software with a dropdown list in the top-right corner, or by editing the `settings.json` file. This settings file is used on each startup to change texts displayed in the app, regarding which language you selected. By default, this software is using English since version 1.1.0, which includes the translation system for the first time.

This translation system has been made to be easily editable. This means that others languages can be added in the future. Actually, no other language than French and English are planned to be added.

### Note about database

The app use raw files located in `LoR_DDragonDownloader/database` folder to retrieve some informations, like availables languages, sets and versions of _Legends of Runeterra_. Please note that GitHub's cache system can prevent the app to detect a recently added version, set or language in the app.

If it happens to you, please exit the app and wait at least 5 minutes before restarting it.

## Editing the app

### Install the software project

```bash
git clone https://github.com/InFinity54/LoR_DDragonDownloader.git LoR_DDragonDownloader
```

### Startup the project in _Visual Studio_

Open file `LoR_DataDragonDownloader.sln` with _Visual Studio_. The minimal version of [_Visual Studio_](https://visualstudio.microsoft.com) for this project is _Visual Studio 2022_. You need to install (with _Visual Studio Installer_) the _.NET Core 3.1 Runtime_ component to be able to open the project.
