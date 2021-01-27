import axios from  'axios'


axios.defaults.withCredentials = true;
axios.defaults.crossDomain = true;
axios.defaults.headers.post['Content-Type'] ='application/x-www-form-urlencoded';
const url="http://nanoreward-001-site2.etempurl.com/api/testproject";
export const GetUsers = async () => {
   try {
     const { data } = await axios.get(url,{ crossdomain: true });
     console.log(data);
     return data;
   } catch (error) {
     console.log(error);
   }
 };