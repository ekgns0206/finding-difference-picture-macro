def callback(wform, frame, sprite, state, parameter):
	try:
		wform.app.Escape()
		return 'press escape'
	except Exception as e:
		return str(e)