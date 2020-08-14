def callback(wform, frame, sprite, state, parameter):
	try:
		location = sprite['expert'].MatchTo(frame)
		wform.app.Click(location)
		return location
	except Exception as e:
		return str(e)