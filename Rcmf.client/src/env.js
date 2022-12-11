export const dev = window.location.origin.includes("localhost");
export const baseURL = dev ? "https://localhost:7045" : "";
export const useSockets = false;
export const domain = "bobocat.us.auth0.com";
export const audience = "https://bcw-demos.com";
export const clientId = "Acd91zZtHgbEyChg4MW53440xBdm6cqE";
export const firebaseConfig = {
  apiKey: "AIzaSyBB4Cc2RvmYrv6lFIzyK3qUnM7RrhT57Q8",
  authDomain: "rcmf-c20bb.firebaseapp.com",
  projectId: "rcmf-c20bb",
  storageBucket: "rcmf-c20bb.appspot.com",
  messagingSenderId: "343563700800",
  appId: "1:343563700800:web:f13a16fb76e837a09e2da5",
  measurementId: "G-63LF04F29S",
};

