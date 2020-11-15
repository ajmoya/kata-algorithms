export class StringValidator {
    private _pairs: Record<string, string> = { '(': ')', '{': '}', '[': ']' };

    validate(text: string): boolean {
        let stack = [];

        for (let character of text) {
            if (this.isOpen(character))
                stack.push(character);
            else {
                var lastCharacter = stack.pop();
                if (!this.closes(lastCharacter!, character))
                    return false;
            }
        }

        return stack.length === 0;
    }

    private isOpen(character: string): boolean {
        return ['(', '{', '['].includes(character);
    }

    private closes(lastCharacter: string, character: string): boolean {
        return character === this._pairs[lastCharacter];
    }
}