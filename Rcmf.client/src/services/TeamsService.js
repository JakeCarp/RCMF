import { AppState } from "../AppState.js";
import { Team } from "../models/Team.js";
import { mySQL } from "./AxiosService.js";

class TeamsService {
  async getTeams() {
    const res = await mySQL.get("api/teams");
    AppState.teams = res.data.map((t) => new Team(t));
  }

  async createTeam(teamData) {
    const res = await mySQL.post("api/teams", teamData);
    let newTeam = new Team(res.data);
    AppState.teams.push(newTeam);
  }

  async deleteTeam(teamId) {
    await mySQL.delete(`api/teams/${teamId}`);
    AppState.teams.filter((t) => t.id != teamId);
  }
  async editTeam(teamData) {
    const res = await mySQL.put("api/teams", teamData);
    let updatedTeam = new Team(res.data);
    let index = AppState.teams.findIndex((t) => {
      t.id == teamData.id;
    });

    AppState.teams.splice(index, 1);
    AppState.teams.push(updatedTeam);
  }
}
export const teamsService = new TeamsService();
