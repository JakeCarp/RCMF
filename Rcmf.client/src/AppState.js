import { reactive } from 'vue'
import { supabase } from './utils/Supabase.js'

// NOTE AppState is a reactive object to contain app level data
export const AppState = reactive({
  user: {},
  /** @type {import('./models/Account.js').Account} */
  account: {},
  supabase: [],


  members:[],
  donation:0,
  grants:[],
  donors:[],
  

})
