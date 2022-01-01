'if something goes wrong, send an email to the programmed address (my personal), so I can take remote action if needed'

Fallback OFF
Set OFF
If Leak_1 CLOSED Then ON 'Closed leak = completed circuit = THERES A LEAK!!!!'
If Leak_2 CLOSED Then ON 'See above'
If Error Cor_9_1 Then ON 'Cor_ objects are the main return pump back to the tank; if something is wrong it needs to be stopped quickly'
If Error Cor_12_1 Then ON
