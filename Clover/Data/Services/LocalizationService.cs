using System.IO;
using Clover.Data.DTO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clover.Data
{
	public class LocalizationService
	{
		public Localizations localizations { get; set; } = new Localizations();

		private LocaleEnum locale = LocaleEnum.HuHu;

		private async Task CheckSettingFile()
		{
			if (!File.Exists("./Data/localizations/setting.txt"))
			{
				var newFile = new StreamWriter("./Data/localizations/setting.txt");
				if (locale == LocaleEnum.HuHu)
				{
					await newFile.WriteAsync("HU_hu");
				}
				else if (locale == LocaleEnum.EnUs)
				{
					await newFile.WriteAsync("EN_us");
				}
				else
				{
					await newFile.WriteAsync("HU_hu");
				}
				newFile.Close();
			}
		}

		public LocaleEnum GetLocale()
		{
			return locale;
		}

		//gets the current localizations without changing it
		public async Task GetLocalizations()
		{
			await CheckSettingFile();
			var getLanguageSetting = new StreamReader("./Data/localizations/setting.txt");
			var setting = await getLanguageSetting.ReadToEndAsync();
			getLanguageSetting.Close();

			switch (setting)
			{
				case "HU_hu":
					await SetHungarianLanguage();
					break;
				case "EN_us":
					await SetEnglishLanguage();
					break;
				default:
					await SetHungarianLanguage();
					break;
			}
		}

		public async Task SetHungarianLanguage()
		{
			var readLanguage = new StreamReader("./Data/localizations/HU_hu.json");
			string json = await readLanguage.ReadToEndAsync();
			readLanguage.Close();
			localizations = JsonSerializer.Deserialize<Localizations>(json);

			var setLanguageDefault = new StreamWriter("./Data/localizations/setting.txt");
			await setLanguageDefault.WriteAsync("HU_hu");
			setLanguageDefault.Close();
			locale = LocaleEnum.HuHu;
		}

		public async Task SetEnglishLanguage()
		{
			var readLanguage = new StreamReader("./Data/localizations/EN_us.json");
			string json = await readLanguage.ReadToEndAsync();
			readLanguage.Close();
			localizations = JsonSerializer.Deserialize<Localizations>(json);

			var setLanguageDefault = new StreamWriter("./Data/localizations/setting.txt");
			await setLanguageDefault.WriteAsync("EN_us");
			setLanguageDefault.Close();
			locale = LocaleEnum.EnUs;
		}
	}
}
