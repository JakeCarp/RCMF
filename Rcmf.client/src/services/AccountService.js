import { AppState } from "../AppState";
import { logger } from "../utils/Logger";
import { mySQL } from "./AxiosService";

class AccountService {
  async getAccount() {
    try {
      const res = await mySQL.get("/account");
      AppState.account = res.data;
    } catch (err) {
      logger.error("HAVE YOU STARTED YOUR SERVER YET???", err);
    }
  }
  // hi
  // is this the right one
}

export const accountService = new AccountService();
