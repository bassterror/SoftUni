function displayProperties(object) {
    var properties = [];
    properties = Object.getOwnPropertyNames(object).sort();
    
    console.log(properties.join('\n'));
}