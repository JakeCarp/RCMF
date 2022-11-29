// import { computed, ref } from "vue";
import { initializeApp } from "firebase/app";
import {
  collection,
  doc,
  getFirestore,
  limit,
  orderBy,
  query,
  addDoc,
  
  
} from "firebase/firestore";
// import firebase from "firebase"
import { useFirestore} from "@vueuse/firebase/useFirestore";

const firebaseConfig = {
  apiKey: "AIzaSyBB4Cc2RvmYrv6lFIzyK3qUnM7RrhT57Q8",
  authDomain: "rcmf-c20bb.firebaseapp.com",
  projectId: "rcmf-c20bb",
  storageBucket: "rcmf-c20bb.appspot.com",
  messagingSenderId: "343563700800",
  appId: "1:343563700800:web:f13a16fb76e837a09e2da5",
  measurementId: "G-63LF04F29S",
};


const app = initializeApp(firebaseConfig);
 export const db = getFirestore(app);

export const chats = useFirestore(collection(db,"chats"));

// const chat = db.collection("chats")
// const chatsRef = FirebaseDocRef(collection(db,"chats"))

class FiresService {
  async addChat(chatsData){

  

    const res = await chats.
    console.log(res);

  }
  // 
}
export const firesService = new FiresService()



