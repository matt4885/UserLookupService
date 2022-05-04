export default class HttpService {
    constructor() {
    }



    async get(url) {
        const response = await fetch(url);

        const data = await response.json();

        return data;
    }

    async post(url, data) {
        const response = await fetch(url, {
            method: "POST",
            body: JSON.stringify(data),
            headers: {
                "Content-Type": "application/json"
            }

        });

    }

}