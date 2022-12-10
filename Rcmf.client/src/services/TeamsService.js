import { AppState } from "../AppState.js";
import { Team } from "../models/Team.js";
import { mySQL } from "./AxiosService.js";

class TeamsService {

  async createTeam(teamData) {
    const res = await mySQL.post("teams", teamData);
    let newTeam = new Team(res.data);
    AppState.teams.push(newTeam);
  }


}
export const teamsService = new TeamsService();
