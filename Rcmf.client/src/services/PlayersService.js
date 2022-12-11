import { AppState } from "../AppState.js"
import { Player } from "../models/Player.js"
import { mySQL } from "./AxiosService.js"

class PlayersService {
async createPlayer(playerData){
  const res = await mySQL.post('players',playerData)
  let newPlayer = new Player(res.data)
  AppState.players.push(newPlayer)
}

}
export const playersService = new PlayersService()