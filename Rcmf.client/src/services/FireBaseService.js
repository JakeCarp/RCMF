import { initializeApp } from "firebase/app";
import {
  collection,
  doc,
  getFirestore,
  limit,
  orderBy,
  query,
  addDoc,
  Firestore,
} from "firebase/firestore";

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
export const db = getFirestore(firebaseApp);
import { getDownloadURL, getStorage, listAll, ref } from "firebase/storage";
import { AppState } from "../AppState.js";
class FiresService {
  async getFaceBookPictures() {
    const storage = getStorage();

    const imagesRef = ref(storage, "facebookPictures");
    const test = await listAll(imagesRef);
    console.log(test);
    for await (const x of test.items) {
      let test = await getDownloadURL(x);
      AppState.photos.push(test);
    }
    return test;

    
  }
  generateId() {
    let timestamp = ((new Date().getTime() / 1000) | 0).toString(16);
    return (
      timestamp +
      "xxxxxxxxxxxxxxxx"
        .replace(/[x]/g, () => ((Math.random() * 16) | 0).toString(16))
        .toLowerCase()
    );
  }
}
export const firesService = new FiresService();
