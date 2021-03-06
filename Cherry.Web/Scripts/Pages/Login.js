﻿import mdcAutoInit from '@material/auto-init';
import { MDCTextField } from '@material/textfield';
import { MDCCheckbox } from '@material/checkbox';
import { MDCLinearProgress } from '@material/linear-progress';
import { MDCRipple } from '@material/ripple'

mdcAutoInit.register('MDCTextField', MDCTextField);
mdcAutoInit.register('MDCRipple', MDCRipple);
mdcAutoInit.register('MDCCheckbox', MDCCheckbox);
mdcAutoInit();

var progress = new MDCLinearProgress(document.querySelector('#progressBar'));
progress.close();
document.querySelector('#loginform').addEventListener("submit", Login);

function Login() {
    progress.open();
    progress.determinate = false;
}