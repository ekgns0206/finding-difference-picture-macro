def callback(wform, frame, sprite, state, parameter):
    try:
        if state['area lists'] is None:
            voffset1        = (142, 26)
            voffset2        = (518, 26)
            vsize           = (365, 616)
            hoffset1        = (142, 26)
            hoffset2        = (142, 340)
            hsize           = (740, 301)

            state['area lists'] = wform.Compare(frame, voffset1, voffset2, vsize) or wform.Compare(frame, hoffset1, hoffset2, hsize)
            if state['area lists'] is None:
                state['clicked'] = []
                wform.History = 'CANNOT FIND LABELS'
            else:
                wform.SetTimer('begin click', 1000, 'begin_click.py')
        elif len(state['centroids']) != 0:
            for areaList in state['area lists']:
                wform.DrawRectangles(areaList)

        #     for area in state['area lists'][0]:
        #         if area in state['clicked']:
        #             continue

        #         x, y, width, height = area
        #         wform.app.Click(x + width // 2, y + height // 2)
        #         state['clicked'].append(area)
        #         break

        #     wform.History = str(len(state['clicked']))
        #     wform.History = str(len(state['area lists'][0]))
        #     if len(state['clicked']) == len(state['area lists'][0]):
        #         state['clicked'] = []
        #         state['area lists'] = None
        #         wform.History = 'Initialize'
    except Exception as e:
        wform.History = str(e)