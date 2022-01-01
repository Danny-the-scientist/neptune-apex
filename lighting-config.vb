'The lights on the system are unique and able to be controlled by the special "sun" command, and indicate the intensity and generalized timing of different colored LEDs. Timings based on this publication - https://www.ncbi.nlm.nih.gov/pmc/articles/PMC5743687/'

Fallback OFF 'If the connection to the system is lost, lights are shut off'
Set OFF 'Normally, the lights are off'
If Sun 000/000 Then ON 'Sun is a command based off the seasons table which indicate sun and moon rise/set to more accurately indicate on/off'
tdata 07:00:00,0,0,0,100,100,100,100,100,100,0,0,0,0 'general programming for intensity of the light and how the different LEDs are active'
tdata 07:59:00,0,0,50,75,75,100,100,100,75,0,0,0,0
tdata 18:00:00,0,0,50,100,100,75,75,75,100,0,0,0,0
tdata 21:00:00,0,0,0,0,0,0,0,0,0,0,0,0,0
