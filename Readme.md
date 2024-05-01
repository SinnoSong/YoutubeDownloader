# YoutubeDownloader

[英文](Readme_EN.md)

[![Build](https://img.shields.io/github/actions/workflow/status/SinnoSong/YoutubeDownloader/main.yml?branch=master)](https://github.com/SinnoSong/YoutubeDownloader/actions)
[![Release](https://img.shields.io/github/release/SinnoSong/YoutubeDownloader.svg)](https://github.com/SinnoSong/YoutubeDownloader/releases)
[![Downloads](https://img.shields.io/github/downloads/SinnoSong/YoutubeDownloader/total.svg)](https://github.com/SinnoSong/YoutubeDownloader/releases)
[![Discord](https://img.shields.io/discord/869237470565392384?label=discord)](https://discord.gg/2SUWKFnHSm)
[![Fuck Russia](https://img.shields.io/badge/fuck-russia-e4181c.svg?labelColor=000000)](https://twitter.com/tyrrrz/status/1495972128977571848)

> 🟡 **项目状态**: 维护状态<sup>[[?]](https://github.com/Tyrrrz/.github/blob/master/docs/project-status.md)</sup>

**YoutubeDownloader**是一个可以从YouTube下载视频的应用程序。您可以复制粘贴任何视频、播放列表或频道的 URL，并将其直接下载为你选择的格式。如果你想快速查找和下载视频，它还支持按关键字搜索。

这个程序使用 [**YoutubeExplode**](https://github.com/Tyrrrz/YoutubeExplode) 库与Youtube进行交互。
> 📝 想详细了解 YouTube 的幕后工作原理?
> 查看 [Reverse-Engineering YouTube: Revisited](https://tyrrrz.me/blog/reverse-engineering-youtube-revisited).

## 使用条款<sup>[[?]](https://github.com/Tyrrrz/.github/blob/master/docs/why-so-political.md)</sup>

通过出于任何目的以任何形式或形式使用本项目或其源代码，您同意**默示同意**以下所有声明：

This application uses [**YoutubeExplode**](https://github.com/Tyrrrz/YoutubeExplode) under the hood to interact with YouTube.

> 📝 Want to learn more about how YouTube works under the hood?
> See [Reverse-Engineering YouTube: Revisited](https://tyrrrz.me/blog/reverse-engineering-youtube-revisited).

## 下载

- 🟢 **[Stable release](https://github.com/SinnoSong/YoutubeDownloader/releases/latest)**
- 🟠 [CI build](https://github.com/SinnoSong/YoutubeDownloader/actions/workflows/main.yml)

## 功能

- 通过 URL 下载视频
- 从播放列表或频道下载视频
- 通过搜索查询下载视频
- 可选择的视频质量和格式
- 自动嵌入字幕
- 自动注入媒体标签

新增功能：

- 下载视频封面
- 下载字幕文件（当字幕文件没有中文时，自动翻译字幕文件）
- 自动翻译标题和视频简介
  - 使用微软（或百度）翻译API，需自行注册Azure（或百度翻译API）账号并创建对应服务
  - 百度翻译需要使用**AppId**和**Key**，微软翻译只需要使用**Key**。如果**AppId不为空**则使用百度翻译，反之使用微软翻译
  - 如果标题中的中文超过60%，则不会翻译视频标题、简介、字幕文件

> **Important**:
> To run **YoutubeDownloader**, you need to make sure that the **.NET 8.0 Runtime** is installed.
> You can download it here:
>
> - [.NET 8.0 Runtime for **macOS x64**](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-8.0.0-macos-x64-installer)
> - [.NET 8.0 Runtime for **macOS arm64**](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-8.0.0-macos-arm64-installer)
> - [.NET 8.0 Runtime for **Linux**](https://learn.microsoft.com/dotnet/core/install/linux) (find the correct download for your distro)
> - On **Windows**, the runtime should be installed automatically when you run the application for the first time

## Features
注：

- Cross-platform graphical user interface
- Download videos by URL
- Download videos from playlists or channels
- Download videos by search query
- Selectable video quality and format
- Automatically embed subtitles
- Automatically inject media tags
- Log in with a YouTube account to access private content
- 新增功能需要进入设置页面设置

## 截图

![list](.assets/list.png)
![single](.assets/single.png)
![multiple](.assets/multiple.png)
![downloadFiles](.assets/downloadFiles.png)
![settings](.assets/settings.png)
