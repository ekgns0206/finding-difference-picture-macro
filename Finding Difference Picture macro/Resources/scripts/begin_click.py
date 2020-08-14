def callback(wform, frame, sprite, state, parameter):
	try:
		if state['area lists'] is None:
			raise Exception()

		state['centroids'] = []
		for area in state['area lists'][0]:
			x, y, width, height = area
			state['centroids'].append((x, y))

		wform.SetTimer('clicking', 500, 'clicking.py')
	except Exception as e:
		wform.History = str(e)

	finally:
		wform.UnsetTimer('begin click')
