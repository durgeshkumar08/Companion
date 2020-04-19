export abstract class CreateOrder {
    businesslogiccommon: string;
    constructor() {
        this.businesslogiccommon = this.getTestMethod();
    }

    public getTestMethod() {
        return 'i am common business logic';
    }
}