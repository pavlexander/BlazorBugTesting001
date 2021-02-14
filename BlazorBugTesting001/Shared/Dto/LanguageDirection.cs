using BlazorBugTesting001.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBugTesting001.Shared.Dto
{
	public class LanguageDirection : ISelectOption
	{
		public string LanguageFrom { get; set; }
		public string LanguageTo { get; set; }
		public string Name
		{
			get
			{
				return $"{LanguageFrom}-{LanguageTo}";
			}
		}

		public string OptionKey
		{
			get
			{
				return Name;
			}
		}

		public string OptionValue
		{
			get
			{
				return Name;
			}
		}

		public LanguageDirection()
		{

		}

		public LanguageDirection(string languageFrom, string languageTo)
		{
			LanguageFrom = languageFrom;
			LanguageTo = languageTo;
		}

		public LanguageDirection(string directionName)
		{
			// todo: add validation
			var splitted = directionName.Split('-');

			LanguageFrom = splitted[0];
			LanguageTo = splitted[1];
		}

		// todo: move to extensions?
		public LanguageDirection SwitchCreateDirection()
		{
			return new LanguageDirection(LanguageTo, LanguageFrom);
		}
	}
}
