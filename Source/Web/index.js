import * as ko from "knockout";

export class index
{
    constructor() {
        var self = this;

        this.timer = ko.observable(0);

        setInterval(() => self.timer(self.timer()+1),1000);
    }
} 