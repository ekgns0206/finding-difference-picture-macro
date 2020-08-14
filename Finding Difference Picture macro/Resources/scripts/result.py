def callback(wform, frame, sprite, state, parameter):
    try:
        wform.app.Click(parameter['re game'])
        wform.InitStopWatch = True
    except Exception as e:
        return str(e)