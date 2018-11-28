{
	"Patterns": null,
	"Items": [
		{
			"Patterns": [
				"[:punct:]"
			],
			"Items": null,
			"Name": "punct",
			"PriorityLiteral": 6
		},
		{
			"Patterns": [
				"\\b\\w{1,}\\b"
			],
			"Items": null,
			"Name": "word",
			"PriorityLiteral": 5
		},
		{
			"Patterns": [
				"\\b(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]|(?:Jan|Mar|May|Jul|Aug|Oct|Dec)))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[1,3-9]|1[0-2]|(?:Jan|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec))\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)(?:0?2|(?:Feb))\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9]|(?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep))|(?:1[0-2]|(?:Oct|Nov|Dec)))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})\\b"
			],
			"Items": null,
			"Name": "date",
			"PriorityLiteral": 0
		},
		{
			"Patterns": [
				"\\b([0-1]?[0-9]|[2][0-3]):([0-5][0-9])(:[0-5][0-9])?\\b"
			],
			"Items": null,
			"Name": "time",
			"PriorityLiteral": 0
		}
	],
	"Name": null,
	"PriorityLiteral": 0
}