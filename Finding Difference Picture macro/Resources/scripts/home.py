def callback(wform, frame, sprite, state, parameter):
	try:
		# wform.app.Click(parameter['search box'])
		# return True

		location = sprite['sudoku icon'].MatchTo(frame)
		wform.app.Click(location)
	except Exception as e:
		return str(e)