﻿using System;
using YoutubeDownloader.Framework;
using YoutubeDownloader.Services;
using YoutubeDownloader.Utils;
using YoutubeDownloader.Utils.Extensions;

namespace YoutubeDownloader.ViewModels.Dialogs;

public class SettingsViewModel : DialogViewModelBase
{
    private readonly SettingsService _settingsService;

    private readonly DisposableCollector _eventRoot = new();

    public SettingsViewModel(SettingsService settingsService)
    {
        _settingsService = settingsService;

        _eventRoot.Add(_settingsService.WatchAllProperties(OnAllPropertiesChanged));
    }

    public bool IsAutoUpdateEnabled
    {
        get => _settingsService.IsAutoUpdateEnabled;
        set => _settingsService.IsAutoUpdateEnabled = value;
    }

    public bool IsDarkModeEnabled
    {
        get => _settingsService.IsDarkModeEnabled;
        set => _settingsService.IsDarkModeEnabled = value;
    }

    public bool IsAuthPersisted
    {
        get => _settingsService.IsAuthPersisted;
        set => _settingsService.IsAuthPersisted = value;
    }

    public bool ShouldInjectSubtitles
    {
        get => _settingsService.ShouldInjectSubtitles;
        set => _settingsService.ShouldInjectSubtitles = value;
    }

    public bool ShouldInjectTags
    {
        get => _settingsService.ShouldInjectTags;
        set => _settingsService.ShouldInjectTags = value;
    }

    public bool ShouldDownloadThumbnail
    {
        get => _settingsService.ShouldDownloadThumbnail;
        set => _settingsService.ShouldDownloadThumbnail = value;
    }

    public bool ShouldDownloadClosedCaption
    {
        get => _settingsService.ShouldDownloadClosedCaptions;
        set => _settingsService.ShouldDownloadClosedCaptions = value;
    }

    public bool ShouldTranslateCCToChinese
    {
        get => _settingsService.ShouldTranslateCCToChinese;
        set => _settingsService.ShouldTranslateCCToChinese = value;
    }

    public bool ShouldSkipExistingFiles
    {
        get => _settingsService.ShouldSkipExistingFiles;
        set => _settingsService.ShouldSkipExistingFiles = value;
    }

    public string FileNameTemplate
    {
        get => _settingsService.FileNameTemplate;
        set => _settingsService.FileNameTemplate = value;
    }

    public string TranslateKey
    {
        get => _settingsService.TranslateKey;
        set => _settingsService.TranslateKey = value;
    }

    public string BaiduAppId
    {
        get => _settingsService.BaiduAppId;
        set => _settingsService.BaiduAppId = value;
    }

    public int ParallelLimit
    {
        get => _settingsService.ParallelLimit;
        set => _settingsService.ParallelLimit = Math.Clamp(value, 1, 10);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _eventRoot.Dispose();
        }

        base.Dispose(disposing);
    }
}
