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

// import { getFirestore } from "firebase/firestore";
// import { getDatabase } from "firebase/database";
// ... other firebase imports

const firebaseConfig = {
  apiKey: "AIzaSyBB4Cc2RvmYrv6lFIzyK3qUnM7RrhT57Q8",
  authDomain: "rcmf-c20bb.firebaseapp.com",
  projectId: "rcmf-c20bb",
  storageBucket: "rcmf-c20bb.appspot.com",
  messagingSenderId: "343563700800",
  appId: "1:343563700800:web:f13a16fb76e837a09e2da5",
  measurementId: "G-63LF04F29S",
};
export const firebaseApp = initializeApp(firebaseConfig);
// export const database = getDatabase(firebaseApp);
export const db = getFirestore(firebaseApp);
// ... other firebase exports
import { useFirestore } from "@vueuse/firebase/useFirestore";

//  export const db = getFirestore(app);

export const chats = useFirestore(collection(db, "chats"));
const chatsRef = collection(db, "chats")
const use = useCollection(chatsRef)
import { useCollection } from "vuefire";

// const chat = db.collection("chats")
// const chatsRef = FirebaseDocRef(collection(db,"chats"))

class FiresService {
  async addChat(chatsData) {
    // console.log(app);
    // console.log(db);

    console.log(firebaseApp);
    console.log(chatsRef);
    console.log(use.value);
    // console.log(chats.collection());
  }
  //
}
export const firesService = new FiresService();
