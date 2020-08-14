def callback(wform, frame, sprite, state, parameter):
	try:
		wform.UnsetTimer('clicking')
		if len(state['centroids']) == 0:
			wform.SetTimer('end click', 3000, 'end_click.py')

		else:
			position = state['centroids'][0]
			wform.app.Click(position)
			wform.History = 'CLICK : {}, {}'.format(position[0], position[1])
			state['centroids'].remove(position)
			wform.SetTimer('clicking', 300, 'clicking.py')
	except Exception as e:
		pass
