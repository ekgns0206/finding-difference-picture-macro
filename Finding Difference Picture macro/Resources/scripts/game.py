from sudoku import *

def convert_cursor(out_row, out_col, in_row, in_col):
    x = (out_col * 181 + in_col * 60 + 11) + 30
    y = (out_row * 181 + in_row * 60 + 159) + 30

    return (x, y)


def callback(wform, frame, sprite, state, parameter):
    try:
        components = wform.Partition(frame)
        table = SUDOKU_TABLE(wform, components)
        count = 0

        if not table.is_valid():
            wform.InitStopWatch = True
            return 'not loaded'

        while True:
            success, out_row, out_col, in_row, in_col, num = table.find_one()
            if not success:
                break

            count = count + 1
            coordination = convert_cursor(out_row, out_col, in_row, in_col)
            wform.app.Click('left', *coordination)

            x = int((num-1) * 516/9 + 23 + 55/2)
            y = 913
            wform.app.Click('left', x, y)
            wform.History = 'Click : {} {} {} {} = {}'.format(out_row, out_col, in_row, in_col, num)

        if table.is_finish():
            return 'finish'

            # if count != 0 and parameter is not None and 'hint' in parameter:
            #     out_row, out_col, in_row, in_col = table.get_least_candidate_coordination()
            #     coordination = convert_cursor(out_row, out_col, in_row, in_col)

            #     wform.app.Click(coordination)
            #     wform.app.Click(parameter['hint'])
            #     wform.InitStopWatch = True
            #     wform.Sleep(3000)
            #     return 'click hint : {}'.format(str(coordination))

        if count == 0:
            wform.InitStopWatch = True
            return str(components)

        return 'Cannot find anymore'



    except Exception as e:
        return str(e)