Config                      = {}
Config.Locale               = GetConvar('betteresx_language', 'en')	 

Config.Accounts             = { 'bank', 'black_money' }
Config.AccountLabels        = { bank = _U('bank'), black_money = _U('black_money') }

Config.EnableSocietyPayouts = GetConvarInt("betteresx_enablesocietypayouts", false) -- pay from the society account that the player is employed at? Requirement: esx_society
Config.ShowDotAbovePlayer   = GetConvarInt("betteresx_showdotaboveplayer", false)
Config.DisableWantedLevel   = GetConvarInt("betteresx_disablewantedlevel", true)
Config.EnableHud            = GetConvarInt("betteresx_enablehud", true) -- enable the default hud? Display current job and accounts (black, bank & cash)

Config.PaycheckInterval     = GetConvarInt("betteresx_paycheckminutes", 7) * 60000
Config.MaxPlayers           = GetConvarInt('sv_maxclients', 32) -- set this value to 255 if you're running OneSync

Config.EnableDebug          = GetConvarInt("betteresx_enabledebug", false)
