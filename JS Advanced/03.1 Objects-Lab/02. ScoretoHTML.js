function convertToHtml(input) {
    let data = JSON.parse(input);
    let outputArr = ["<table>"];
    outputArr.push(makeKeyRow(data));
    data.forEach(obj => {
        outputArr.push(makeValueRow(obj))
    });
    outputArr.push("</table>");

    function makeKeyRow(str) {
        let row = `\t<tr><th>name</th><th>score</th></tr>`;
        return row;
    }
    function makeValueRow(obj) {
        let name = obj["name"];
        if (name.includes("&") || name.includes("<") || name.includes(">") || name.includes("\"")) {
            name = escapeHtml(name);
        }
        let row = `\t<tr><td>${name}</td><td>${obj["score"]}</td></tr>`;
        return row;
    };
    function escapeHtml(value) {
        let result = value.split()
            .map(x => (replaceAll(x, "&", "&amp;")))
            .map(x => (replaceAll(x, "<", "&lt;")))
            .map(x => (replaceAll(x, ">", "&gt;")))
            .map(x => (replaceAll(x, "\"", "&quot;")))
            .map(x => (replaceAll(x, "\'", "&#39;")));
        return result;
    };

    function replaceAll(stri, find, replace) {
        return stri.replace(new RegExp(find, "g"), replace);
    };
    console.log(outputArr.join('\n'));
}

// convertToHtml(['[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]'])
// convertToHtml(['[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]'])
convertToHtml(`[{"name":"Pencho Penchev","score":0},{"name":"<script>alert(Wrong!)</script>","score":1}]`)