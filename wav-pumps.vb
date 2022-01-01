'WAV pump programming for randomized water movement:'

Fallback Malibu_1 'Fallback refers to what happens when the connection to the unit fails; Malibu is a gentle, randomized flow'
tdata 00:00:00,0,0,1,0,0,0,0,0,0,0,0,0,0 'These rows indicate intensity and timing for on/off of the WAV'
tdata 02:00:00,0,0,1,2,0,0,0,0,0,0,0,0,0
tdata 04:00:00,0,0,0,0,0,0,0,0,0,0,0,0,0
tdata 06:00:00,0,0,1,2,0,0,0,0,0,0,0,0,0
tdata 08:00:00,0,0,0,0,0,0,0,0,0,0,0,0,0
tdata 10:00:00,0,0,1,2,0,0,0,0,0,0,0,0,0
tdata 12:00:00,0,0,0,0,0,0,0,0,0,0,0,0,0
tdata 14:00:00,0,0,1,1,0,0,0,0,0,0,0,0,0
tdata 16:00:00,0,0,0,0,0,0,0,0,0,0,0,0,0
tdata 18:00:00,0,0,1,2,0,0,0,0,0,0,0,0,0
tdata 20:00:00,0,0,0,0,0,0,0,0,0,0,0,0,0
tdata 22:00:00,0,0,1,2,0,0,0,0,0,0,0,0,0
If FeedA 000 Then OFF 'FeedA is a button command and 000 indicates it's active, so the WAV shuts off during feeding'
If Output feedSeymour = ON Then OFF 'Virtual outputs are able to be made based off certain conditions, and can be named anything you want, below feeding output shuts off the WAV'
If Output vacayFeed = ON Then OFF
If Output ceaseFeed = ON Then Malibu_1
If Output allStop = ON Then OFF
If TogSw2 OPEN Then OFF 'One of my basic toggle switches turns the WAV on and off'
