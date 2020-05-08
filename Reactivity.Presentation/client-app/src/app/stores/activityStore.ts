import { observable, action } from "mobx";
import { createContext } from "react";
import { IActivity } from "../models/activity";
import agent from "../api/agent";

class ActivityStore {
    @observable activities: IActivity[] = [];
    @observable loadingInitial = false;

    @action loadActitvities = () => {
        this.loadingInitial = true;
        agent.Activities.list()
            .then((activities) => {
                activities.forEach((act) => {
                    act.date = act.date.split(".")[0];
                    this.activities.push(act);
                });
            })
            .finally(() => (this.loadingInitial = false));
    };
}

export default createContext(new ActivityStore());
