const LongestCommonPrefix = require('./LongestCommonPrefix');

test('checks against three words for common prefix', () => {
    expect(LongestCommonPrefix(['flower','flood','fling']).toBe('fl'));
});

