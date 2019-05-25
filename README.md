# BetterESX
BetterESX is a roleplay framework for FiveM. It is developed on top of [EssentialMode](https://essentialmode.com/) (aka ES)

### Links & Read more
- [ESX Documentation](https://esx-org.github.io/)
- [ES Documentation](https://docs.essentialmode.com/)

### Screenshot preview (todo)

![screenshot](http://i.imgur.com/aPFdJl3.jpg)

### Features
- Accounts (bank / black money). You can add further accounts
- Advanced inventory system (press `F2` ingame)
- Job system
- Loadouts and position synced in database
- The best framework out there for RP servers
- i18n (locale) system
- Plenty of plugins available

### Requirements
This order also applies in the startup order.

- [fxmigrant](https://github.com/blattersturm/fxmigrant)
- [mysql-async](https://github.com/brouznouf/fivem-mysql-async)
- [essentialmode](https://github.com/kanersps/essentialmode)
- [esplugin_mysql](https://github.com/kanersps/esplugin_mysql)
- [async](https://github.com/ESX-Org/async)

### Download & Installation

### Using Git

```
cd resources
git clone https://github.com/blattersturm/fxmigrant
git clone https://github.com/ESX-Org/es_extended [essential]/es_extended
git clone https://github.com/ESX-Org/esx_menu_default [esx]/[ui]/esx_menu_default
git clone https://github.com/ESX-Org/esx_menu_dialog [esx]/[ui]/esx_menu_dialog
git clone https://github.com/ESX-Org/esx_menu_list [esx]/[ui]/esx_menu_list
```

### Manually
- Download https://github.com/blattersturm/fxmigrant/releases/latest
- Put it in the `resource/` directory
- Download https://github.com/ESX-Org/es_extended/releases/latest
- Put it in the `resource/[essential]` directory
- Download https://github.com/ESX-Org/esx_menu_default/releases/latest
- Put it in the `resource/[esx]/[ui]` directory
- Download https://github.com/ESX-Org/esx_menu_dialog/releases/latest
- Put it in the `resource/[esx]/[ui]` directory
- Download https://github.com/ESX-Org/esx_menu_list/releases/latest
- Put it in the `resource/[esx]/[ui]` directory

## Installation
- No database configuration required! (Only create an "essentialmode" database for esplugin_mysql)
- Configure your `server.cfg` to look like this

```
start mysql-async
start essentialmode
start esplugin_mysql

start es_extended

start esx_menu_default
start esx_menu_list
start esx_menu_dialog
```
# Legal
### License
BetterESX licensed under AGPLv3 according to the requirement set by https://github.com/kanersps/essentialmode
