'Control of the heating element power based off temperature probe readings and heaters internal thermometer'

Fallback ON 'Keep the heater on if connection is lost; it has an internal thermometer to keep steady temp'
If Tmp < 77.0 Then ON 'Self explanatory, designating the low end of OK temp'
If Tmp > 78.0 Then OFF 'High end of OK so shut off'
If TogSw4 OPEN Then OFF 'Toggle switch can manually disable the electrical outlet'
If Output allStop = ON Then OFF 'allStop does mean everything'
