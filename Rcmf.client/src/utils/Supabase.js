import { createClient } from "@supabase/supabase-js";
import { supabaseAnonKey, supabaseUrl } from "../env";
import Pop from "./Pop";



export const supabase = createClient(supabaseUrl, supabaseAnonKey);



// class SupabaseService {
//   async addSupabaseChat(chat) {
//     try {
//       console.log(chat,);
//       // const res = await supabase.from("chats").upsert(chat).select();
//       // console.log(res);
//     } catch (error) {
//       Pop.error(error);
//     }
//   }
// }
// export const supabaseService = new SupabaseService();
