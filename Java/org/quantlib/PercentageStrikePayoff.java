/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class PercentageStrikePayoff extends Payoff {
  private transient long swigCPtr;

  protected PercentageStrikePayoff(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.PercentageStrikePayoff_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(PercentageStrikePayoff obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_PercentageStrikePayoff(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public PercentageStrikePayoff(Option.Type type, double moneyness) {
    this(QuantLibJNI.new_PercentageStrikePayoff(type.swigValue(), moneyness), true);
  }

}
