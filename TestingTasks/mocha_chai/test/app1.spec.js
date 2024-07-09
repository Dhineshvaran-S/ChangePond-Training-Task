const { suite ,test} = require('mocha');
const {areaofcircle} = require ('../src/app1')



let expect ;
(async ()=> {
    const chai = await import ('chai');
    expect =chai.expect;
})();

suite ('suite 5',()=>{
    test('areaofcircle(2) should return 12.56  ', ()=>{
        expect(areaofcircle(2)).to.be.equal(12.56);
    })
})
