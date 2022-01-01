'Programming to control the auto-feed module/component for going on vacation, etc.'

OSC 000:00/000:30/000:30 Then ON 'leave on for ~30 seconds when it happens; OSC is oscilations in this instance'
If Time 00:00 to 07:01 Then OFF 'have a specific feeding time'
If Time 07:03 to 00:00 Then OFF 'so feeding happens between 0701 and 0703'
If DoW SM-W-F- Then OFF 'Days of the week when feeding occurs; Sunday, Monday, Wednesday, Friday'
If FeedA 000 Then ON 'can also be activation by the sort of StandIn feeding command'
