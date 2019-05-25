resource_manifest_version '44febabe-d386-4d18-afbe-5e627f4af937'

version '0.1.0'

dependencies {
	'fxmigrant',
	'mysql-async',
	'essentialmode',
	'esplugin_mysql',
	'async'
}

description 'BetterESX for EssentialMode'

migration_files {
    'server/migrations/0001_add_users.cs',
	'server/migrations/0002_create_items.cs',
	'server/migrations/0003_create_job_grades.cs',
	'server/migrations/0004_populate_job_grades.cs',
	'server/migrations/0005_create_jobs.cs',
	'server/migrations/0006_populate_jobs.cs',
	'server/migrations/0007_create_user_accounts.cs',
	'server/migrations/0008_create_user_inventory.cs',
	'server/migrations/0009_create_addons.cs',
	'server/migrations/0010_create_datastore.cs'
}

server_scripts {
	'@async/async.lua',
	'@mysql-async/lib/MySQL.lua',
	'@fxmigrant/helper.lua',

	'common/locale.lua',
	'common/locales/de.lua',
	'common/locales/br.lua',
	'common/locales/fr.lua',
	'common/locales/en.lua',
	'common/locales/fi.lua',
	'common/locales/sv.lua',
	'common/locales/pl.lua',
	'common/locales/cs.lua',

	'common/config/config.lua',
	'common/config/config.weapons.lua',

	'server/common.lua',
	'server/classes/player.lua',
	'server/functions.lua',
	'server/paycheck.lua',
	'server/main.lua',
	'server/commands.lua',

	'common/modules/math.lua',
	'common/modules/table.lua',
	'common/functions.lua'
}

client_scripts {
	'common/locale.lua',
	'common/locales/de.lua',
	'common/locales/br.lua',
	'common/locales/fr.lua',
	'common/locales/en.lua',
	'common/locales/fi.lua',
	'common/locales/sv.lua',
	'common/locales/pl.lua',
	'common/locales/cs.lua',

	'common/config/config.lua',
	'common/config/config.weapons.lua',

	'client/common.lua',
	'client/entityiter.lua',
	'client/functions.lua',
	'client/wrapper.lua',
	'client/main.lua',

	'client/modules/death.lua',
	'client/modules/scaleform.lua',
	'client/modules/streaming.lua',

	'common/modules/math.lua',
	'common/modules/table.lua',
	'common/functions.lua'
}

ui_page {
	'html/ui.html'
}

files {
	'common/locale.js',
	'html/ui.html',

	'html/css/app.css',

	'html/js/mustache.min.js',
	'html/js/wrapper.js',
	'html/js/app.js',

	'html/fonts/pdown.ttf',
	'html/fonts/bankgothic.ttf',

	'html/img/accounts/bank.png',
	'html/img/accounts/black_money.png'
}

exports {
	'getSharedObject'
}

server_exports {
	'getSharedObject'
}
